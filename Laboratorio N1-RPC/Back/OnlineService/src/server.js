import dotenv from 'dotenv';
import grpc from '@grpc/grpc-js';
import protoLoader from '@grpc/proto-loader';

dotenv.config()

const PROTO_PATH = process.env.PROTO_PATH;
const REMOTE_HOST = process.env.REMOTE_HOST;

const packageDefinition = protoLoader.loadSync(
  PROTO_PATH,
  {
    keepCase: true,
    longs: String,
    enums: String,
    defaults: true,
    oneofs: true
  });

console.info("Consumer service is started...");

function check(client, name) {
  client.CheckItem({ item: name, num: 0 }, (err, data) => {
    if (err) {
      console.log(err);
    } else {
      console.log('Response received from remote service:', data); // API response
    }
  });
}

function change(client, name, n) {
  client.ChangeItem({ item: name, num: n }, (err, data) => {
    if (err) {
      console.log(err);
    } else {
      console.log('Response received from remote service:', data); // API response
    }
  });
}

const productService = grpc.loadPackageDefinition(packageDefinition).ProductService;

function main() {

  const client = new productService(REMOTE_HOST, grpc.credentials.createInsecure());

  check(client, "Coffee");
  check(client, "Pens");
  change(client, "Pens", 1);
  check(client, "Pens");
  change(client, "Pens", -1);

};

main();
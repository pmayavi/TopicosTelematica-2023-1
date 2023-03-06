import dotenv from 'dotenv';
import grpc from '@grpc/grpc-js';
import protoLoader from '@grpc/proto-loader';

dotenv.config()

const PROTO_PATH = process.env.PROTO_PATH;
const REMOTE_HOST1 = process.env.REMOTE_HOST1;
const REMOTE_HOST2 = process.env.REMOTE_HOST2;

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
const inventoryService = grpc.loadPackageDefinition(packageDefinition).InventoryService;

function main() {

  const bank = new productService(REMOTE_HOST1, grpc.credentials.createInsecure());
  check(bank, "1234");
  check(bank, "cero");
  check(bank, "4321");
  check(bank, "noExiste");

  const inv = new inventoryService(REMOTE_HOST2, grpc.credentials.createInsecure());

  check(inv, "Coffee");
  check(inv, "Pens");
  change(inv, "Pens", 1);
  check(inv, "Pens");
  change(inv, "Pens", -1);
};

main();
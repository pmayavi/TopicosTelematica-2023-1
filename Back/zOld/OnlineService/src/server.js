import dotenv from 'dotenv';
import grpc from '@grpc/grpc-js';
import protoLoader from '@grpc/proto-loader';

dotenv.config()

const PROTO_PATH = process.env.PROTO_PATH;
const REMOTE_HOST1 = process.env.REMOTE_HOST1;
const REMOTE_HOST2 = process.env.REMOTE_HOST2;
const REMOTE_HOST3 = process.env.REMOTE_HOST3;

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

function checkB(client, name) {
  client.CheckBank({ item: name, num: 0 }, (err, data) => {
    if (err) {
      console.log(err);
    } else {
      console.log('Response received from remote service:', data); // API response
    }
  });
}

function ship(client, add, it) {
  client.ShipItem({ address: add, item: it }, (err, data) => {
    if (err) {
      console.log(err);
    } else {
      console.log('Response received from remote service:', data); // API response
    }
  });
}

const paymentService = grpc.loadPackageDefinition(packageDefinition).PaymentService;
const inventoryService = grpc.loadPackageDefinition(packageDefinition).InventoryService;
const shipmentService = grpc.loadPackageDefinition(packageDefinition).ShipmentService;

function main() {

  const bank = new paymentService(REMOTE_HOST1, grpc.credentials.createInsecure());

  checkB(bank, "1234");
  checkB(bank, "cero");
  checkB(bank, "4321");
  checkB(bank, "noExiste");

  const inv = new inventoryService(REMOTE_HOST2, grpc.credentials.createInsecure());

  check(inv, "Coffee");
  check(inv, "Pens");
  change(inv, "Pens", 1);
  check(inv, "Pens");
  change(inv, "Pens", -1);

  const shi = new shipmentService(REMOTE_HOST3, grpc.credentials.createInsecure());
  ship(shi, "Home", "Pens");
};

main();
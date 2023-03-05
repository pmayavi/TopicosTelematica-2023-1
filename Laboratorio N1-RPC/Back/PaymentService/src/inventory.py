
from concurrent import futures

import json
import grpc
import Service_pb2
import Service_pb2_grpc

HOST = '[::]:8080'


class ProductService(Service_pb2_grpc.ProductServiceServicer):
    def CheckItem(self, response, context):
        print(response)
        print(response[1])
        print(response[item])
        item = response[1]
        print("\nRequest is received: " + item)
        with open("inventory.json", "r") as inv:
            inventory = json.loads(inv.read())

        if (item in inventory and inventory[item] > 0):
            return Service_pb2.TransactionResponse(status=1, inventory=inventory[item])
        else:
            return Service_pb2.TransactionResponse(status_code=0, inventory=0)

    def ChangeItem(self, response, context):
        print(response)
        print(response[1])
        print(response[2])
        item = response[1]
        num = response[2]
        with open("inventory.json", "r") as inv:
            inventory = json.loads(inv.read())
        inventory[item] += num
        with open("inventory.json", "w") as outfile:
            json.dump(inventory, outfile, indent=4)
        return Service_pb2.TransactionResponse(status=1, inventory=inventory[item])


def serve():
    server = grpc.server(futures.ThreadPoolExecutor(max_workers=10))
    Service_pb2_grpc.add_ProductServiceServicer_to_server(
        ProductService(), server)
    server.add_insecure_port(HOST)
    print("Service is running... ")
    server.start()
    server.wait_for_termination()


if __name__ == "__main__":
    serve()

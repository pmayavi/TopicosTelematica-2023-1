
from concurrent import futures

import json
import grpc
import Service_pb2
import Service_pb2_grpc

HOST = '[::]:8080'


class ProductService(Service_pb2_grpc.ProductServiceServicer):
    def CheckItem(self, response, context):
        item = response.item
        with open("banks.json", "r") as inv:
            inventory = json.loads(inv.read())
        if item in inventory:
            inventory[item] -= 100
            with open("banks.json", "w") as outfile:
                json.dump(inventory, outfile, indent=4)
            print("Request is received: " + item +
                  " now has " + str(inventory[item]))
        else:
            print("Card doesn't exist.")
            return Service_pb2.TransactionResponse(status=0, inventory=0)
        return Service_pb2.TransactionResponse(status=1, inventory=inventory[item])

    def ChangeItem(self, response, context):
        pass


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

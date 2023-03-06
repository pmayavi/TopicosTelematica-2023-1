
from concurrent import futures

import json
import grpc
import Service_pb2
import Service_pb2_grpc

HOST = '[::]:8080'


class InventoryService(Service_pb2_grpc.InventoryServiceServicer):
    def CheckItem(self, response, context):
        item = response.item
        print("\nRequest is received: " + item)
        with open("inventory.json", "r") as inv:
            inventory = json.loads(inv.read())

        if (item in inventory and inventory[item] > 0):
            print("\nRequest is received: " + item +
                  " has " + str(inventory[item]))
            return Service_pb2.TransactionResponse(status=1, inventory=inventory[item])
        else:
            print("\nRequest is received: " + item + " has 0")
            return Service_pb2.TransactionResponse(status=0, inventory=0)

    def ChangeItem(self, response, context):
        item = response.item
        num = response.num
        with open("inventory.json", "r") as inv:
            inventory = json.loads(inv.read())
        inventory[item] += num
        with open("inventory.json", "w") as outfile:
            json.dump(inventory, outfile, indent=4)
        print("\nRequest is received: " + item +
              " now has " + str(inventory[item]))
        return Service_pb2.TransactionResponse(status=1, inventory=inventory[item])


def serve():
    server = grpc.server(futures.ThreadPoolExecutor(max_workers=10))
    Service_pb2_grpc.add_InventoryServiceServicer_to_server(
        InventoryService(), server)
    server.add_insecure_port(HOST)
    print("Service is running... ")
    server.start()
    server.wait_for_termination()


if __name__ == "__main__":
    serve()

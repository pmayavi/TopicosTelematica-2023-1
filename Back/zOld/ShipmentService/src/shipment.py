
from concurrent import futures

import json
import grpc
import Service_pb2
import Service_pb2_grpc

HOST = '[::]:8080'


class ShipmentService(Service_pb2_grpc.ShipmentServiceServicer):
    def ShipItem(self, response, context):
        address = response.address
        item = response.item
        with open("shiped.json", "r") as shi:
            ship = json.loads(shi.read())
        ship[address] = item
        with open("banks.json", "w") as outfile:
            json.dump(ship, outfile, indent=4)
        print("Request is received: " + address + " now has " + item)
        return Service_pb2.TransactionResponse(status=1, inventory=0)


def serve():
    server = grpc.server(futures.ThreadPoolExecutor(max_workers=10))
    Service_pb2_grpc.add_ShipmentServiceServicer_to_server(
        ShipmentService(), server)
    server.add_insecure_port(HOST)
    print("Service is running... ")
    server.start()
    server.wait_for_termination()


if __name__ == "__main__":
    serve()

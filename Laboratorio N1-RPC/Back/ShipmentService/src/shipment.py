
from concurrent import futures

import json
import grpc
import Service_pb2
import Service_pb2_grpc

HOST = '[::]:8080'


class PaymentService(Service_pb2_grpc.PaymentServiceServicer):
    def CheckItem(self, response, context):
        pass

    def ChangeItem(self, response, context):
        item = response.item
        num = response.num
        with open("shiped.json", "r") as shi:
            ship = json.loads(shi.read())
        ship[item] = num
        with open("banks.json", "w") as outfile:
            json.dump(ship, outfile, indent=4)
        print("Request is received: " + item + " now has " + str(num))


def serve():
    server = grpc.server(futures.ThreadPoolExecutor(max_workers=10))
    Service_pb2_grpc.add_PaymentServiceServicer_to_server(
        PaymentService(), server)
    server.add_insecure_port(HOST)
    print("Service is running... ")
    server.start()
    server.wait_for_termination()


if __name__ == "__main__":
    serve()

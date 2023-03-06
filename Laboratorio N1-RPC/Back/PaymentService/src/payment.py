
from concurrent import futures

import json
import grpc
import Service_pb2
import Service_pb2_grpc

HOST = '[::]:8080'


class ProductService(Service_pb2_grpc.ProductServiceServicer):
    def CheckItem(self, response, context):
        bank = response.item
        return Service_pb2.TransactionResponse(status=1, inventory=100)

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

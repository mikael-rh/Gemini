from __future__ import print_function
import grpc

import simulation_pb2
import simulation_pb2_grpc

def run():
    channel = grpc.insecure_channel('192.168.86.98:12346')
    stub = simulation_pb2_grpc.SimulationStub(channel)

    #result = stub.SetStartTime(simulation_pb2.SetStartTimeRequest(time=0.0))

    result = stub.Render(simulation_pb2.RenderRequest(render=True))


if __name__ == "__main__":
    run()

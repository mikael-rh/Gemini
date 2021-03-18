# Generated by the gRPC Python protocol compiler plugin. DO NOT EDIT!
"""Client and server classes corresponding to protobuf-defined services."""
import grpc

import simulation_pb2 as simulation__pb2


class SimulationStub(object):
    """Missing associated documentation comment in .proto file."""

    def __init__(self, channel):
        """Constructor.

        Args:
            channel: A grpc.Channel.
        """
        self.DoStep = channel.unary_unary(
                '/simulation.Simulation/DoStep',
                request_serializer=simulation__pb2.StepRequest.SerializeToString,
                response_deserializer=simulation__pb2.StepResponse.FromString,
                )
        self.SetStartTime = channel.unary_unary(
                '/simulation.Simulation/SetStartTime',
                request_serializer=simulation__pb2.SetStartTimeRequest.SerializeToString,
                response_deserializer=simulation__pb2.SetStartTimeResponse.FromString,
                )
        self.Render = channel.unary_unary(
                '/simulation.Simulation/Render',
                request_serializer=simulation__pb2.RenderRequest.SerializeToString,
                response_deserializer=simulation__pb2.RenderResponse.FromString,
                )


class SimulationServicer(object):
    """Missing associated documentation comment in .proto file."""

    def DoStep(self, request, context):
        """Missing associated documentation comment in .proto file."""
        context.set_code(grpc.StatusCode.UNIMPLEMENTED)
        context.set_details('Method not implemented!')
        raise NotImplementedError('Method not implemented!')

    def SetStartTime(self, request, context):
        """Missing associated documentation comment in .proto file."""
        context.set_code(grpc.StatusCode.UNIMPLEMENTED)
        context.set_details('Method not implemented!')
        raise NotImplementedError('Method not implemented!')

    def Render(self, request, context):
        """Missing associated documentation comment in .proto file."""
        context.set_code(grpc.StatusCode.UNIMPLEMENTED)
        context.set_details('Method not implemented!')
        raise NotImplementedError('Method not implemented!')


def add_SimulationServicer_to_server(servicer, server):
    rpc_method_handlers = {
            'DoStep': grpc.unary_unary_rpc_method_handler(
                    servicer.DoStep,
                    request_deserializer=simulation__pb2.StepRequest.FromString,
                    response_serializer=simulation__pb2.StepResponse.SerializeToString,
            ),
            'SetStartTime': grpc.unary_unary_rpc_method_handler(
                    servicer.SetStartTime,
                    request_deserializer=simulation__pb2.SetStartTimeRequest.FromString,
                    response_serializer=simulation__pb2.SetStartTimeResponse.SerializeToString,
            ),
            'Render': grpc.unary_unary_rpc_method_handler(
                    servicer.Render,
                    request_deserializer=simulation__pb2.RenderRequest.FromString,
                    response_serializer=simulation__pb2.RenderResponse.SerializeToString,
            ),
    }
    generic_handler = grpc.method_handlers_generic_handler(
            'simulation.Simulation', rpc_method_handlers)
    server.add_generic_rpc_handlers((generic_handler,))


 # This class is part of an EXPERIMENTAL API.
class Simulation(object):
    """Missing associated documentation comment in .proto file."""

    @staticmethod
    def DoStep(request,
            target,
            options=(),
            channel_credentials=None,
            call_credentials=None,
            insecure=False,
            compression=None,
            wait_for_ready=None,
            timeout=None,
            metadata=None):
        return grpc.experimental.unary_unary(request, target, '/simulation.Simulation/DoStep',
            simulation__pb2.StepRequest.SerializeToString,
            simulation__pb2.StepResponse.FromString,
            options, channel_credentials,
            insecure, call_credentials, compression, wait_for_ready, timeout, metadata)

    @staticmethod
    def SetStartTime(request,
            target,
            options=(),
            channel_credentials=None,
            call_credentials=None,
            insecure=False,
            compression=None,
            wait_for_ready=None,
            timeout=None,
            metadata=None):
        return grpc.experimental.unary_unary(request, target, '/simulation.Simulation/SetStartTime',
            simulation__pb2.SetStartTimeRequest.SerializeToString,
            simulation__pb2.SetStartTimeResponse.FromString,
            options, channel_credentials,
            insecure, call_credentials, compression, wait_for_ready, timeout, metadata)

    @staticmethod
    def Render(request,
            target,
            options=(),
            channel_credentials=None,
            call_credentials=None,
            insecure=False,
            compression=None,
            wait_for_ready=None,
            timeout=None,
            metadata=None):
        return grpc.experimental.unary_unary(request, target, '/simulation.Simulation/Render',
            simulation__pb2.RenderRequest.SerializeToString,
            simulation__pb2.RenderResponse.FromString,
            options, channel_credentials,
            insecure, call_credentials, compression, wait_for_ready, timeout, metadata)
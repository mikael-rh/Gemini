using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Sensorstreaming;
using Google.Protobuf;
using Grpc.Core;
using Gemini.EMRS.RGB;

namespace Gemini.Networking.Clients
{
    public class CameraClient : Client<CameraImage>
    {
        private SensorStreaming.SensorStreamingClient _grpcCameraStreamingClient;
        public CameraClient()
        {
            _grpcCameraStreamingClient = new SensorStreaming.SensorStreamingClient(channel);
        }

        public override bool SendMessage(CameraImage image)
        {

            bool success = false;
            connectionTime = Time.time;
             
            if(connectionTime < ConnectionTimeout || connected)
            {
                try
                {
                    success = _grpcCameraStreamingClient.StreamCameraSensor(
                        new CameraStreamingRequest{ Data = image.data, TimeStamp = image.time, FrameId = image.frameID, 
                                                    Height = image.height, Width = image.width }).Success;
                    connected = success;
                } catch (RpcException e)
                {
                    Debug.LogException(e);
                }
            }

            return success;

        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Google.Protobuf;
using Grpc.Core;
using GeminiOSPInterface;

namespace Gemini.Networking.Services
{
    public class SimulationController : MonoBehaviour
    {
        public string host = "localhost";

        private int _port = 12346;

        public int Port
        {
            get => _port;
        }

        public GameObject[] boatPrefabs;

        private Server server;

        private SimulationServiceImpl serviceImpl;

        private GameObject[] _boats;

        private string _startTime;

        void Start()
        {

            _boats = new GameObject[boatPrefabs.Length];
            for (int prefabIdx = 0; prefabIdx < boatPrefabs.Length; prefabIdx++)
            {
                _boats[prefabIdx] = Instantiate(boatPrefabs[prefabIdx], new Vector3(0, 0, 0), Quaternion.identity);
            }

            //serviceImpl = new SimulationServiceImpl(this);

            server = new Server
            {
                Services = { Simulation.BindService(serviceImpl) },
                Ports = { new ServerPort(host, _port, ServerCredentials.Insecure) }
            };

            Debug.Log("Simulation server listening on port: " + _port);
            server.Start();
        }

        public StepResponse DoStep(StepRequest request)
        {
            UpdateBoats(request);
            return new StepResponse{Success = true};
        }

        public SetStartTimeResponse SetStartTime(SetStartTimeRequest request)
        {
            _startTime = request.Time;
            return new SetStartTimeResponse{Success = true};
        }

        private void UpdateBoats(StepRequest request)
        {
            Debug.Log("Updating boats");
            List<VesselPose> poses = new List<VesselPose>();

            // Converting the poses that to a simple List<Pose> instead of ReapeatedField
            foreach (GeminiOSPInterface.Pose pose in request.VesselPoses)
            {
                poses.Add(new VesselPose(pose.North, pose.East, pose.Heading));
            }

            for (int boatIdx = 0; boatIdx < _boats.Length; boatIdx++)
            {
                if (boatIdx < _boats.Length)
                {
                    _boats[boatIdx].transform.position = new Vector3(poses[boatIdx].East,0,poses[boatIdx].North);
                    float Heading = poses[boatIdx].Heading;
                    Quaternion QuaternionRot = Quaternion.AngleAxis(Heading, new Vector3(0, 1, 0));
                    _boats[boatIdx].transform.rotation = QuaternionRot;
                }
            }
        }
    }
}

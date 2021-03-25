using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Google.Protobuf;
using Grpc.Core;
using GeminiOSPInterface;

namespace Gemini.Networking.Services
{
    public class ControllerBase : MonoBehaviour
    {
        public string host = "localhost";

        private int _port = 12346;

        public int Port
        {
            get => _port;
        }
        protected static bool isServerinInitialized = false;

        public GameObject[] boatPrefabs;

        private SimulationServiceImpl serviceImpl;
        protected Server server = new Server
                {
                    Services = {},
                    Ports = {}
                };
    

        void Awake()
        {
            if (!isServerinInitialized) 
            {
                server = new Server
                {
                    Services = {Simulation.BindService(serviceImpl)},
                    Ports = { new ServerPort(host, _port, ServerCredentials.Insecure) }
                };

                Debug.Log("Simulation server listening on port: " + _port);
                server.Start();
                isServerinInitialized = true;
            }
        }

        /*
        void Start()
        {
            if (!isServerinInitialized) 
            {
                server = new Server
                {
                    Services = { Simulation.BindService(serviceImpl) },
                    Ports = { new ServerPort(host, _port, ServerCredentials.Insecure) }
                };

                Debug.Log("Simulation server listening on port: " + _port);
                server.Start();
                isServerinInitialized = true;
            }
        }
        */
    }
}

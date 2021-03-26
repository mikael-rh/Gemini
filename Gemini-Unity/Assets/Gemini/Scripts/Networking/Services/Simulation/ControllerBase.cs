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

        protected int _port = 12346;

        public int Port
        {
            get => _port;
        }
        protected static bool isServerinInitialized = false;

        protected static Server server;
    }
}

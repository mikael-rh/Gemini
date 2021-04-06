using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Grpc.Core;

namespace Gemini.Networking.Clients {
    public abstract class Client<T>
    {
        private static string serverIP = "192.168.1.235";

        private static int serverPort = 30052;

        protected static Channel channel = new Channel(serverIP + ":" + serverPort, ChannelCredentials.Insecure);

        protected const float ConnectionTimeout = 2.0f;
        protected float connectionTime;
        protected bool connected = false;

        public abstract bool SendMessage(T sensorType);

    }
}

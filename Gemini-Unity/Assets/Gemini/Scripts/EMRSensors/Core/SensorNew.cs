using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
using Gemini.Networking.Clients;

namespace Gemini.EMRS.Core {
    public abstract class SensorNew<T> : MonoBehaviour
    {

        //public bool RunRecording = false;
        protected T _sensorData;

        protected bool hasSentDataOnPrevUpdate = false;

        protected Client<T> _client;

        public T SensorData {
            get {return _sensorData;}
        }

        public enum SensorCallbackOrder
        {
            First,
            Last
        };

        public struct SensorCallback
        {
            public System.Action<ScriptableRenderContext, Camera[]> _callback;
            public SensorCallbackOrder _executionOrder;
            public SensorCallback(System.Action<ScriptableRenderContext, Camera[]> callback, SensorCallbackOrder executionOrder)
            {
                _callback = callback;
                _executionOrder = executionOrder;
            }
        };

        void Update()
        {
        }

        private SensorCallback[] sensorCallbackList;

        public void SetupSensorCallbacks(params SensorCallback[] sensorCallbacks)
        {
            sensorCallbackList = sensorCallbacks;
        }

        private void AddSensorCallbacks(params SensorCallback[] sensorCallbacks)
        {
            foreach (SensorCallback sensorCallback in sensorCallbacks)
            {
                if(sensorCallback._executionOrder == SensorCallbackOrder.First)
                {
                    RenderPipelineManager.beginFrameRendering += sensorCallback._callback;
                }
                else if(sensorCallback._executionOrder == SensorCallbackOrder.Last)
                {
                    RenderPipelineManager.endFrameRendering += sensorCallback._callback;
                }
            }
        }

        private void RemoveSensorCallbacks(params SensorCallback[] sensorCallbacks)
        {
            foreach (SensorCallback sensorCallback in sensorCallbacks)
            {
                if (sensorCallback._executionOrder == SensorCallbackOrder.First)
                {
                    RenderPipelineManager.beginFrameRendering -= sensorCallback._callback;
                }
                else if (sensorCallback._executionOrder == SensorCallbackOrder.Last)
                {
                    RenderPipelineManager.endFrameRendering -= sensorCallback._callback;
                }
            }
        }

        public void OnEnable()
        {
            AddSensorCallbacks(sensorCallbackList);
        }

        public void OnDisable()
        {
            RemoveSensorCallbacks(sensorCallbackList);
        }

        // External Helper functions
        //public static SensorNew<T>[] GetActiveSensors()
        //{
        //    var _sensors = GameObject.FindObjectsOfType<SensorNew<T>>();
        //    return _sensors;
        //}
    }
}
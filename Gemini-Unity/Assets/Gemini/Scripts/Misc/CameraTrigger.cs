using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Gemini.Misc
{
    [RequireComponent(typeof(Camera))]
    public class CameraTrigger : MonoBehaviour
    {
        public Camera camera;
        public RenderTexture renderTexture;
         

        // Start is called before the first frame update
        void Start()
        {
            camera.targetTexture = renderTexture;
            camera.enabled = false;
        }

        public void Render()
        {
            camera.Render(); 
        }

        /*
        void Update()
        {
            Debug.Log("Updating");
           
            if (Time.time > 10.0)
            {
                Debug.Log("Rendering frame");
                camera.Render();
            }
        }
        */
    }
}

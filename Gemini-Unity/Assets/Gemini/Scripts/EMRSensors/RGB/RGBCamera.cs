using UnityEngine;
using UnityEngine.Rendering;
using Gemini.EMRS.Core;
using Gemini.EMRS.Core.ZBuffer;
using Gemini.Networking.Clients;
using Google.Protobuf;

namespace Gemini.EMRS.RGB
{
    public struct CameraImage {

        public CameraImage(float time, string frameID, uint height, uint width)
        {
            data = ByteString.CopyFrom();
            this.time = time;
            this.frameID = frameID;
            this.height = height;
            this.width = width;
        }

        public ByteString data;
        public float time;
        public string frameID;
        public uint height;
        public uint width;
    }

    [RequireComponent(typeof(Camera))]
    public class RGBCamera : SensorNew<CameraImage>
    {
        public RenderTexture _cameraBuffer { get; set; }
        public RenderTexture SampleCameraImage;
        public ComputeShader cameraShader;
        public string FrameID = "F";
        public int ImageCrop = 4;
        public bool SynchronousUpdate = false;

        private bool _hasRenderedWhenUpdated = false;

        public bool HasRenderedWhenUpdated
        {
            get => _hasRenderedWhenUpdated;
            set => _hasRenderedWhenUpdated = value;
        }

        private Camera camera;
        private UnifiedArray<byte> cameraData;
        private RenderTextureFormat renderTextureFormat = RenderTextureFormat.Default;
        private TextureFormat textureFormat = TextureFormat.RGB24;

        private float time = 0f;

        [Space]
        [Header("Camera Parameters")]
        public int PixelWidth = 2448;
        public int PixelHeight = 2048;
        public float FarPlane = 10000f;
        public float NearPlane = 0.08f;
        public float focalLengthMilliMeters = 5.5f;
        public float pixelSizeInMicroMeters = 3.45f;
        public DepthBits DepthBufferPrecision = DepthBits.Depth24;
        public ByteString Data { get; private set; } = ByteString.CopyFromUtf8("");


        private void Awake()
        {
            SetupSensorCallbacks(new SensorCallback(RGBUpdate, SensorCallbackOrder.Last)); 
        }

        private void Start()
        {
            _sensorData = new CameraImage(0f, FrameID, (uint)(PixelHeight / ImageCrop), (uint)(PixelWidth / ImageCrop));

            CameraSetup();

            int kernelIndex = cameraShader.FindKernel("CSMain");
            cameraData = new UnifiedArray<byte>(PixelHeight * PixelWidth, sizeof(float) * 3, "CameraData");
            cameraData.SetBuffer(cameraShader, "CSMain");
            cameraShader.SetTexture(kernelIndex, "RenderTexture", camera.targetTexture);
            cameraShader.SetInt("Width", PixelWidth / ImageCrop);
            cameraShader.SetInt("Height", PixelHeight / ImageCrop);
        }


        private void RGBUpdate(ScriptableRenderContext context, Camera[] cameras)
        {
            if (SynchronousUpdate)
            {
                cameraData.SynchUpdate(cameraShader, "CSMain");
                _sensorData.data = ByteString.CopyFrom(cameraData.array);
            }
            else
            {
                AsyncGPUReadback.Request(camera.activeTexture, 0, textureFormat, ReadbackCompleted);
            }
        }

        private void ReadbackCompleted(AsyncGPUReadbackRequest request)
        {
            _sensorData.data = ByteString.CopyFrom(request.GetData<byte>().ToArray());
        }

        private byte[] RenderTextureToBinary(Camera cam)
        {
            // The Render Texture in RenderTexture.active is the one
            // that will be read by ReadPixels.
            var currentRT = RenderTexture.active;
            RenderTexture.active = cam.targetTexture;

            // Make a new texture and read the active Render Texture into it.
            Texture2D image = new Texture2D(cam.targetTexture.width, cam.targetTexture.height, textureFormat, false, true);
            image.ReadPixels(new Rect(0, 0, cam.targetTexture.width, cam.targetTexture.height), 0, 0);
            image.Apply();

            // Replace the original active Render Texture.
            RenderTexture.active = currentRT;
            return image.EncodeToPNG();
        }

        private void CameraSetup()
        {
            CameraFrustum frustums = new CameraFrustum(PixelWidth, PixelHeight, FarPlane, NearPlane, focalLengthMilliMeters, pixelSizeInMicroMeters);
            _cameraBuffer = new RenderTexture(PixelWidth / ImageCrop, PixelHeight / ImageCrop, (int)DepthBufferPrecision, renderTextureFormat, 0);

            camera = gameObject.GetComponent<Camera>();
            camera.usePhysicalProperties = false;
            camera.targetTexture = _cameraBuffer;

            camera.aspect = frustums._aspectRatio;//Mathf.Tan(Mathf.PI / numbers) / Mathf.Tan(frustums._verticalAngle / 2.0f);
            Debug.Log("Aspect Ratio RGB: " + frustums._aspectRatio.ToString());
            camera.fieldOfView = frustums._verticalAngle * Mathf.Rad2Deg;//Camera.HorizontalToVerticalFieldOfView(360.0f / numbers, cam.aspect);
            camera.farClipPlane = frustums._farPlane;
            camera.nearClipPlane = frustums._nearPlane;
            //camera.enabled = false;
        }

        public static RGBCamera[] GetActiveCameras()
        {
            return GameObject.FindObjectsOfType<RGBCamera>();
        }
    }
}

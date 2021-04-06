using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Navigation;
using Gemini.Core;
using Grpc.Core;

namespace Gemini.Networking.Clients
{
    /*
    public class NavClientNew : Client
    {
        
        private Navigation.Navigation.NavigationClient _grpcNavigationClient;
        private Vec3 _navPosition;
        private Navigation.Quaternion _navOrientation;
        private Vec3 _navLinearVelocity;
        private Vec3 _navAngularVelocity;

        private Vector3 _unityPosition;
        private UnityEngine.Quaternion _unityOrientation;
        private Vector3 _unityLinearVelocity;
        private Vector3 _unityAngularVelocity;

        public NavClientNew()
        {
            _grpcNavigationClient = new Navigation.Navigation.NavigationClient(channel);

            _navPosition = new Vec3();
            _navOrientation = new Navigation.Quaternion();

            _navLinearVelocity = new Vec3();
            _navAngularVelocity = new Vec3();
        }
        
        public void UpdateNavigation(Transform transform)
        {

            _unityPosition = ConventionTransforms.PositionUnityToNED(transform.position);

            _unityOrientation = UnityEngine.Quaternion.Euler(ConventionTransforms.EulerOrientationUnityToNED(transform.rotation.eulerAngles));
                
            // Set Navigation Position and orientation to the same value as the Unity position and orientation
            // TODO: This should be done in a own function
            _navPosition.X = _unityPosition.x;
            _navPosition.Y = _unityPosition.y;
            _navPosition.Z = _unityPosition.z;

            _navOrientation.X = _unityOrientation.x;
            _navOrientation.Y = _unityOrientation.y;
            _navOrientation.Z = _unityOrientation.z;
            _navOrientation.W = _unityOrientation.w;

            // TODO: In the future this should either be estimated from position and time
            // or this should be retreived from a Rigidbody component, depending on which
            // type of simulation that is running.
            _navLinearVelocity.X = 0.0f;
            _navLinearVelocity.Y = 0.0f;
            _navLinearVelocity.Z = 0.0f;

            _navAngularVelocity.X = 0.0f;
            _navAngularVelocity.Y = 0.0f;
            _navAngularVelocity.Z = 0.0f;
        }

        public override bool SendMessage()    
        {
            bool success = false;

            connectionTime = Time.time;

            if (connectionTime < ConnectionTimeout || connected)
            {
                try
                {
                    success = _grpcNavigationClient.SendNavigationMessage(
                        new NavigationRequest
                        {
                            TimeStamp = 3.14,
                            Position = _navPosition,
                            Orientation = _navOrientation,
                            LinearVelocity = _navLinearVelocity,
                            AngularVelocity = _navAngularVelocity
                        }).Success;

                    connected = success;
                } catch (RpcException e)
                {
                    Debug.LogException(e);
                } 
            }

            return success;
        }
    }

    */
}


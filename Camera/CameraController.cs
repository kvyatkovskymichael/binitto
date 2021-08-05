using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Application.Camera
{
    public class CameraController : MonoBehaviour
    {
        public float smoothValue;
        public Transform target;

        private Transform _cameraTransform;
        private Vector3 _cameraVelocity;
        private Vector3 _targetPosition;

        private void Start()
        {
            _cameraTransform = transform;
            _cameraVelocity = Vector3.zero;
        }

        private void Update()
        {
            _targetPosition = new Vector3(
                0f,
                target.position.y,
                -10f
                );

            _cameraTransform.position = Vector3.SmoothDamp(
                _cameraTransform.position,
                _targetPosition,
                ref _cameraVelocity,
                smoothValue);
        }
    }
}

﻿using UnityEngine;

public class FaceCamera : MonoBehaviour
{
    private void OnEnable()
    {
        Transform cameraTransform;
        
        (cameraTransform = transform).LookAt(CameraFollow.MainCamera.transform);
        Vector3 euler = cameraTransform.eulerAngles;
        euler.x = 0;
        euler.z = 0;
        cameraTransform.eulerAngles = euler;
    }
}

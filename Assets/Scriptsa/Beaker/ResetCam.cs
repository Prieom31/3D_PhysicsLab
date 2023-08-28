using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetCam : MonoBehaviour
{
    private float startingFieldOfView;
    private Vector3 startingPosition;
    private Quaternion startingRotation;

    public Camera customCamera; // Public variable to reference the custom camera

    private void Awake()
    {
        startingFieldOfView = customCamera.fieldOfView; // Use the custom camera for field of view
        startingPosition = transform.position;
        startingRotation = transform.rotation;
    }

    public void ResetCameraPos()
    {
        customCamera.fieldOfView = startingFieldOfView; // Use the custom camera for field of view
        transform.position = startingPosition;
        transform.rotation = startingRotation;
    }
}

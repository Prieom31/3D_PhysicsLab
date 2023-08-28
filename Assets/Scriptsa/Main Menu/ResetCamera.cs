using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetCamera : MonoBehaviour
{
    private float startingFieldOfView;
    private Vector3 startingPosition;
    private Quaternion startingRotation;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void Awake()
    {
        startingFieldOfView = Camera.main.fieldOfView;
        startingPosition = transform.position;
        startingRotation = transform.rotation;
    }

    public void ResetCameraPos()
    {
        Camera.main.fieldOfView = startingFieldOfView;
        transform.position = startingPosition;
        transform.rotation = startingRotation;
    }


}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PerspectivePan : MonoBehaviour
{
    float MouseZoomSpeed = -15.0f;
    float TouchZoomSpeed = 0.1f;
    float ZoomMinBound = 20.0f;
    float ZoomMaxBound = 50.0f;
    Camera cam;



    // Start is called before the first frame update
    void Start()
    {
         cam = GetComponent<Camera>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.touchSupported)
        {

            if (Input.touchCount == 2)
            {
                //Get posiction

                Touch tZero = Input.GetTouch(0);
                Touch tOne = Input.GetTouch(1);

                //Get current position of touch from previus frame


                Vector2 tZeroPrevius = tZero.position - tZero.deltaPosition;
                Vector2 tOnePrevius = tOne.position - tOne.deltaPosition;



                float oldTouchDistance = Vector2.Distance(tZeroPrevius, tOnePrevius);
                float CurrentDistance = Vector2.Distance(tZero.position, tOne.position);


                //GET offset value

                float DeltaDistance = oldTouchDistance - CurrentDistance;
                zoom(DeltaDistance, TouchZoomSpeed);


            }

        }
        else
        {
            float scroll = Input.GetAxis("Mouse ScrollWheel");
            zoom(scroll, MouseZoomSpeed);
        }

        if (cam.fieldOfView < ZoomMinBound)
        {

            cam.fieldOfView = 20.0f;

        }
        else if (cam.fieldOfView > ZoomMaxBound)
        {

            cam.fieldOfView = 50.0f;
        }
    }
    void zoom(float DeltaDistanceDiff, float speed)
    {
        cam.fieldOfView += DeltaDistanceDiff * speed;
        //set clamp for cam.fieldOfView

        cam.fieldOfView = Mathf.Clamp(cam.fieldOfView, ZoomMinBound, ZoomMaxBound);

    }
}
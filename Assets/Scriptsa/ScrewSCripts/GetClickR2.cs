using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
public class GetClickR2 : MonoBehaviour
{
    public bool enableScript = true;
    float rotSpeed = 20;
    void Start()
    {
        enableScript = false;
    }

    public void DisableRotate()
    {
        enableScript = false;
    }
    public void EnableRotate()
    {
        enableScript = true;
    }
    void OnMouseDrag()
    {
        if (enableScript)
        {

            float rotX = Input.GetAxis("Mouse X") * rotSpeed * Mathf.Deg2Rad;
            //float rotY = Input.GetAxis("Mouse Y") * rotSpeed * Mathf.Deg2Rad;

            transform.RotateAround(Vector3.up, -rotX);
            //transform.RotateAround(Vector3.right, -rotY);
        }
    }
}

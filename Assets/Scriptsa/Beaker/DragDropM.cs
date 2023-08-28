using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class DragDropM : MonoBehaviour
{
    Vector3 offset;
    public string destinationTag = "TheDropArea";
    public bool enableScript1 = true;
    public bool isFalling = false;
    public bool isRising = false;
    private ConstantForce cForce;
    private Vector3 forceDirection;
    private Vector3 forceDirection1;

    public Camera customCamera; // Public variable to reference the custom camera

    void Start()
    {
        cForce = GetComponent<ConstantForce>();
        forceDirection1 = cForce.force;
    }

    private void FixedUpdate()
    {
        if (isFalling)
        {
            Fall();
        }
        if (isRising)
        {
            forceDirection = new Vector3(0, 0.02f, 0);
            cForce.force = forceDirection;
        }
    }

    private void Fall()
    {
        forceDirection = new Vector3(0, -0.02f, 0);
        cForce.force = forceDirection;
    }

    public void Rise()
    {
        isRising = true;
    }

    public void DisableDrag()
    {
        enableScript1 = false;
    }

    public void EnableDrag()
    {
        enableScript1 = true;
    }

    void OnMouseDown()
    {
        offset = transform.position - MouseWorldPosition();
        transform.GetComponent<Collider>().enabled = false;
    }

    void OnMouseDrag()
    {
        transform.position = MouseWorldPosition() + offset;
        isRising = false;
        isFalling = false;
        cForce.force = forceDirection1;
    }

    void OnMouseUp()
    {
        var rayOrigin = customCamera.transform.position; // Use the custom camera for raycasting
        var rayDirection = MouseWorldPosition() - customCamera.transform.position;
        RaycastHit hitInfo;
        if (Physics.Raycast(rayOrigin, rayDirection, out hitInfo))
        {
            if (hitInfo.transform.tag == destinationTag)
            {
                transform.position = hitInfo.transform.position;
                isFalling = true;
            }
        }
        transform.GetComponent<Collider>().enabled = true;
    }

    Vector3 MouseWorldPosition()
    {
        var mouseScreenPos = Input.mousePosition;
        mouseScreenPos.z = customCamera.WorldToScreenPoint(transform.position).z; // Use the custom camera
        return customCamera.ScreenToWorldPoint(mouseScreenPos);
    }
}

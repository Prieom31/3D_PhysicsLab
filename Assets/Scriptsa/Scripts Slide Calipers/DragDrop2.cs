using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
public class DragDrop2 : MonoBehaviour
{
    Vector3 offset;
    public string destinationTag = "DropArea2";
    public bool enableScript1 = true;
    void Start()
    {
        enableScript1 = false;
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
        if (enableScript1)
        {
            offset = transform.position - MouseWorldPosition();
            transform.GetComponent<Collider>().enabled = false;
        }
    }

    void OnMouseDrag()
    {
        if (enableScript1)
        {
            transform.position = MouseWorldPosition() + offset;
        }
    }

    void OnMouseUp()
    {
        if (enableScript1)
        {
            var rayOrigin = Camera.main.transform.position;
            var rayDirection = MouseWorldPosition() - Camera.main.transform.position;
            RaycastHit hitInfo;
            if (Physics.Raycast(rayOrigin, rayDirection, out hitInfo))
            {
                if (hitInfo.transform.tag == destinationTag)
                {
                    transform.position = hitInfo.transform.position;
                }
            }
            transform.GetComponent<Collider>().enabled = true;
        }
    }
    Vector3 MouseWorldPosition()
    {

        var mouseScreenPos = Input.mousePosition;
        mouseScreenPos.z = Camera.main.WorldToScreenPoint(transform.position).z;
        return Camera.main.ScreenToWorldPoint(mouseScreenPos);
    }
}
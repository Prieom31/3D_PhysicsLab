using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragDrop4 : MonoBehaviour
{
    Vector3 offset;
    public string destinationTag = "TheDropArea2";
    public GameObject Draganim;
    public GameObject Lwh;
    public GameObject Skipb;
    public GameObject DialogTut;
    public GameObject Slidet;
    public GameObject Taptut;
    public GameObject SlideRtl;
    void OnMouseDown()
    {
        offset = transform.position - MouseWorldPosition();
        transform.GetComponent<Collider>().enabled = false;
    }

    void OnMouseDrag()
    {
        transform.position = MouseWorldPosition() + offset;
    }

    void OnMouseUp()
    {
        var rayOrigin = Camera.main.transform.position;
        var rayDirection = MouseWorldPosition() - Camera.main.transform.position;
        RaycastHit hitInfo;
        if (Physics.Raycast(rayOrigin, rayDirection, out hitInfo))
        {
            if (hitInfo.transform.tag == destinationTag)
            {
                transform.position = hitInfo.transform.position;
                Draganim.SetActive(false);
               
                if(Skipb.activeSelf && !Draganim.activeSelf && !DialogTut.activeSelf && !Slidet.activeSelf && !Taptut.activeSelf)
                {
                    Lwh.SetActive(true);
                    Invoke("HideLwh", 3f);
                }
               
                
            }
        }
        transform.GetComponent<Collider>().enabled = true;
    }
    void HideLwh()
    {
        Lwh.SetActive(false);
        SlideRtl.SetActive(true);
    }

    Vector3 MouseWorldPosition()
    {
        var mouseScreenPos = Input.mousePosition;
        mouseScreenPos.z = Camera.main.WorldToScreenPoint(transform.position).z;
        return Camera.main.ScreenToWorldPoint(mouseScreenPos);
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
public class GetClickedMove : MonoBehaviour
{
   
    public GameObject vernierScale;
    
    public float force = 10.0f;
    private Rigidbody rb;
    private bool isSelected = false;
    public Slider slider;
    public float speed1=0.01f;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        
        


        if (isSelected)
        {
            
            float mouseX = Input.GetAxis("Mouse X");
            //Vector3 speed = new Vector3(mouseX, 0, 0)*(-force);
            //rb.AddForce(speed);
            slider.value += mouseX * speed1;
        }

    }


    public void OnMouseDown()
    {

        
       
            if (vernierScale == getClickedObject(out RaycastHit hit))
            {

                
                isSelected = true;
                print("Clicked");
            }
        
     

    }

    private void OnMouseUp()
    {
        isSelected = false;
    }


    GameObject getClickedObject(out RaycastHit hit)
    {
        GameObject target = null;
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(ray.origin, ray.direction * 10, out hit))
        {
            if (!isPointerOverUIObject()) { target = hit.collider.gameObject; }
        }
        return target;
    }

    private bool isPointerOverUIObject()
    {
        PointerEventData ped = new PointerEventData(EventSystem.current);
        ped.position = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
        List<RaycastResult> results = new List<RaycastResult>();
        EventSystem.current.RaycastAll(ped, results);
        return results.Count > 0;
    }

}


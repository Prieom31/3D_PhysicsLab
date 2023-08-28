using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
  //  public float xx1,xx2,yy1,yy2,zz1,zz2;
    public float xspeed = 0.0001f;
    public bool ismovingleft = false;
    public bool ismovingright = false;
    private Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {

        //Move();
        
    }
    private void FixedUpdate()
    {
        Move();
    }
    void Move()
    {
      
        if (ismovingright)
        {
            MoveRight();
            
        }
        if (ismovingleft)
        {
            MoveLeft();
          
        }
    }

    public void TriggerRight(bool canMove)
    {
        ismovingright = canMove;

    }
    public void Triggerleft(bool canMove)
    {
        ismovingleft = canMove;

    }
  

    public void MoveRight()
    {


        //transform.position -= new Vector3(xspeed, 0, 0);
        rb.AddForce(-transform.forward * xspeed* Time.deltaTime);

        
    }
    public void MoveLeft() 
    {

        //transform.position += new Vector3(xspeed, 0, 0);
        rb.AddForce(transform.forward * xspeed* Time.deltaTime);

    }
    


}




using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBallHolder : MonoBehaviour
{
    public float zspeed = 1.00f;
    public bool ismovingleft = false;
    public bool ismovingright = false;
    // Start is called before the first frame update
    void Start()
    {

    }
    // Update is called once per frame
    void Update()
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
        transform.position -= new Vector3(0, 0, zspeed);
    }
    public void MoveLeft()
    {
        transform.position += new Vector3(0, 0, zspeed);
    }


}
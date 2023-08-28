using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotateee : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void LengthRotate()
    {
        transform.rotation = Quaternion.Euler(0,0,0);
    }

    public void WidthRotate()
    {
        transform.rotation = Quaternion.Euler(0, 0, 90);
    }

    public void HeigthRotate()
    {
        transform.rotation = Quaternion.Euler(0, 90, 0);
    }
   
}

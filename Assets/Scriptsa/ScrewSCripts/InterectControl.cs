using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InterectControl : MonoBehaviour
{
    public Behaviour scriptA;
 
    // Start is called before the first frame update
    void Start()
    {

    }

    public void EnableScript()
    {
        scriptA.enabled = true;
       
    }

    public void DisableScript()
    {
        scriptA.enabled = false;

    }
    // Update is called once per frame
    void Update()
    {

    }
}
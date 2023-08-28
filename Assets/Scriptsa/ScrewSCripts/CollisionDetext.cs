using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionDetext : MonoBehaviour
{
    private Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Collision Detected");
        animator.speed = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReduceSphereMargin : MonoBehaviour
{
    private void Start()
    {
        Collider collider = GetComponent<Collider>();
        collider.contactOffset = 0.01f;

        if (collider is SphereCollider)
        {
            SphereCollider sphereCollider = (SphereCollider)collider;
            sphereCollider.radius = 1f;
        }
    }
}
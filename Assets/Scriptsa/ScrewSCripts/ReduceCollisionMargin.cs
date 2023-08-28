using UnityEngine;

public class ReduceCollisionMargin : MonoBehaviour
{
    private void Start()
    {
        Collider collider = GetComponent<Collider>();
        collider.contactOffset = 0.001f;

        if (collider is BoxCollider)
        {
            BoxCollider boxCollider = (BoxCollider)collider;
            boxCollider.size = new Vector3(0.1f, 0.1f, 0.1f);
        }
    }
}


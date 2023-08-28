using UnityEngine;

public class CollisionS : MonoBehaviour
{
    public bool isColliding = false;

    private void OnCollisionEnter(Collision collision)
    {
        isColliding = true;
        Debug.Log("Collided");
    }

    private void OnCollisionExit(Collision collision)
    {
        isColliding = false;
    }
}

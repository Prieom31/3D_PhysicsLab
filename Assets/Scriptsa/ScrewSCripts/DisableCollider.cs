using UnityEngine;

public class DisableCollider : MonoBehaviour
{
    public GameObject objectWithCollider;

    private Collider colliderComponent;

    private void Start()
    {
        if (objectWithCollider != null)
        {
            // Get the Collider component on the object with the collider
            colliderComponent = objectWithCollider.GetComponent<Collider>();
        }
        else
        {
            Debug.LogWarning("objectWithCollider is not set on the DisableCollider script on " + gameObject.name);
        }
    }

    public void DisableTheCollider()
    {
        if (colliderComponent != null)
        {
            // Set the enabled property of the Collider component to false
            colliderComponent.enabled = false;
        }
        else
        {
            Debug.LogWarning("No Collider component found on " + objectWithCollider.name);
        }
    }
    public void EnableTheCollider()
    {
        if (colliderComponent != null)
        {
            // Set the enabled property of the Collider component to false
            colliderComponent.enabled = true;
        }
        else
        {
            Debug.LogWarning("No Collider component found on " + objectWithCollider.name);
        }
    }
}

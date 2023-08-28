using UnityEngine;

public class PosChanger : MonoBehaviour
{
    public RandomMovement randomMovement;

    private Vector3 previousPosition;

    private void Start()
    {
        // Store the initial position of the game object
        previousPosition = transform.position;
    }

    private void LateUpdate()
    {
        // Check if the position of the game object has changed
        if (transform.position != previousPosition)
        {
            // Call the SetNewPosition() function in the RandomMovement script
           // randomMovement.SetNewPosition(transform.position);
        }

        // Update the previous position
        previousPosition = transform.position;
    }
}

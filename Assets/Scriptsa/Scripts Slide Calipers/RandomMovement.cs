using UnityEngine;

public class RandomMovement : MonoBehaviour
{
    public float movementDistanceX = 2.0f;
    public float movementDistanceY = 2.0f;
    public float movementSpeed = 1.0f;

    private Vector3 startingPosition;
    private Vector3 targetPosition;

    private void Start()
    {
        // Store the starting position of the GameObject
        startingPosition = transform.position;

        // Initialize the target position to the starting position
        targetPosition = startingPosition;
    }

    private void Update()
    {
        // If the GameObject has reached the target position, generate a new target position
        if (transform.position == targetPosition)
        {
            // Generate a random position within the specified distance from the starting position in the X-Y plane
            float randomDistanceX = Random.Range(0.0f, movementDistanceX);
            float randomDistanceY = Random.Range(0.0f, movementDistanceY);
            Vector3 randomDirection = new Vector3(Random.Range(-1.0f, 1.0f), Random.Range(-1.0f, 1.0f), 0.0f);
            targetPosition = startingPosition + Vector3.Scale(randomDirection.normalized, new Vector3(randomDistanceX, randomDistanceY, 0.0f));
        }

        // Move the GameObject towards the target position at the specified speed
        transform.position = Vector3.MoveTowards(transform.position, targetPosition, movementSpeed * Time.deltaTime);
    }
}

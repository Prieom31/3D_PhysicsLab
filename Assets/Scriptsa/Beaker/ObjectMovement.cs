using UnityEngine;
using UnityEngine.UI;

public class ObjectMovement : MonoBehaviour
{
    public Slider slider;
    public float minYPosition = 0f;
    public float maxYPosition = 10f;
    public float moveSpeed = 5f;
    public float movementMultiplier = 0.00889f;

    private float initialYPosition;

    private void Start()
    {
        initialYPosition = transform.position.y;
    }

    private void Update()
    {
        float targetYPosition = Mathf.Lerp(minYPosition, maxYPosition, slider.value);
        float deltaValue = slider.value + 0.005f;
        float movementAmount = deltaValue * movementMultiplier;
        float newYPosition = initialYPosition + movementAmount;
        Vector3 newPosition = new Vector3(transform.position.x, newYPosition, transform.position.z);
        transform.position = Vector3.MoveTowards(transform.position, newPosition, moveSpeed * Time.deltaTime);
    }
}

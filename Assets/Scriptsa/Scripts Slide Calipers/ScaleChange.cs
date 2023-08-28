using UnityEngine;
using UnityEngine.UI;

public class ScaleChange : MonoBehaviour
{
    public Transform gameObject1; // Reference to the first game object
    public Transform gameObject2; // Reference to the second game object
    public Button increaseButton; // Reference to the button for increasing scale

    private Vector3 initialScale; // Initial local scale of gameObject1
    private float scaleFactor = 0.00111f;
    private float posFactor = 0.00055f;
        // Amount to scale gameObject1

    private void Start()
    {
        // Store the initial local scale of gameObject1
        initialScale = gameObject1.localScale;

        // Attach a listener to the button's click event
        increaseButton.onClick.AddListener(IncreaseScaleAndPosition);
    }

    private void IncreaseScaleAndPosition()
    {
        // Increase the localScale.x of gameObject1 by the scaleFactor
        gameObject1.localScale += new Vector3(scaleFactor, 0f, 0f);

        // Calculate the position change for gameObject2
        float positionChange = posFactor * -1f;

        // Update the position.x of gameObject2
        gameObject2.position += new Vector3(positionChange, 0f, 0f);
    }
}

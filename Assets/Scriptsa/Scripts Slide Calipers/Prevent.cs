using UnityEngine;
using UnityEngine.UI;

public class Prevent : MonoBehaviour
{
    public GameObject collisionDetector;

    private Slider slider;
    private float previousValue;

    private void Start()
    {
        slider = GetComponent<Slider>();
        previousValue = slider.value;
    }

    private void Update()
    {
        if (collisionDetector != null)
        {
            if (collisionDetector.GetComponent<CollisionDetector>().isColliding && Input.GetMouseButton(0) && slider.value > slider.minValue)
            {
                // Prevent the slider from decreasing its value
                slider.value = Mathf.Max(previousValue-0.1f, slider.value);
            }
            else
            {
                previousValue = slider.value;
            }
        }
    }
}

using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Rigidbody))]
public class MoveObjectWithSlider : MonoBehaviour
{
    public Slider slider;
    public float moveSpeed = 1f;
    public float maxSpeed = 10f;
    public float damping = 0.2f;

    private Rigidbody rb;
    private Vector3 startPosition;
    private float previousSliderValue;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        startPosition = transform.position;
        previousSliderValue = slider.value;
    }

    /*    void FixedUpdate()
        {
            float sliderValue = slider.value;
            float sliderValueDiff = sliderValue - previousSliderValue;

            // Calculate the force based on the time step
            Vector3 force = new Vector3(sliderValueDiff * -moveSpeed / Time.fixedDeltaTime, 0, 0);
            rb.AddForce(force, ForceMode.Acceleration);

            if (sliderValue == previousSliderValue)
            {
                // Apply damping to gradually reduce the velocity
                rb.velocity *= (1f - damping * Time.fixedDeltaTime);
            }

            if (rb.velocity.magnitude > maxSpeed)
            {
                rb.velocity = rb.velocity.normalized * maxSpeed;
            }

            previousSliderValue = sliderValue;
        }*/

    void FixedUpdate()
    {
        float sliderValue = slider.value;
        float sliderValueDiff = sliderValue - previousSliderValue;
        Vector3 velocity = new Vector3(sliderValueDiff * -moveSpeed, 0, 0);
        rb.velocity = velocity;

        if (rb.velocity.magnitude > maxSpeed)
        {
            rb.velocity = rb.velocity.normalized * maxSpeed;
        }

        previousSliderValue = sliderValue;
    }


    public void OnZoom()
    {
        slider.interactable = false;
    }
    public void OffZoom()
    {
        slider.interactable = true;
    }
}

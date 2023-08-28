using UnityEngine;
using UnityEngine.UI;

public class SliderControl : MonoBehaviour
{
    public Slider slider1;
    public Slider slider2;

    private bool isIncreasing = false;
    private float valueDifference = 0.02f;

    private void Start()
    {
        // Add event listener to slider2's onValueChanged event
        slider2.onValueChanged.AddListener(OnSlider2ValueChanged);
    }

    private void OnSlider2ValueChanged(float value)
    {
        if (value < slider2.value)
        {
            // Jump to 0.05 less than slider2 value
            float adjustedValue = value - valueDifference;

            // Update the value of slider1 directly
            slider1.value = adjustedValue;

            // Set the flag to indicate decreasing
            isIncreasing = false;
        }
        else
        {
            // Set the flag to indicate increasing
            isIncreasing = true;
        }
    }

    private void Update()
    {
        if (isIncreasing)
        {
            // Gradually update the value of slider1 towards the new value
            slider1.value = Mathf.Lerp(slider1.value, slider2.value, Time.deltaTime);
        }
    }

    public void Interf()
    {
        slider2.interactable = false;
    }

    public void Intert()
    {
        slider2.interactable = true;
    }
}

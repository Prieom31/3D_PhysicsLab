using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class SliderSlowDown : MonoBehaviour
{
    public Slider slider;
    public float speed = 0.1f;

    private bool isSliding = false;
    private float targetValue;

    private void Update()
    {
        if (isSliding)
        {
            float newValue = Mathf.MoveTowards(slider.value, targetValue, speed * Time.deltaTime);
            slider.value = newValue;
            if (newValue == targetValue)
            {
                isSliding = false;
            }
        }
    }

    public void OnPointerDown()
    {
        isSliding = true;
        targetValue = slider.value;
    }

    public void OnPointerUp()
    {
        isSliding = false;
    }

    public void OnDrag(float value)
    {
        targetValue = value;
    }
}
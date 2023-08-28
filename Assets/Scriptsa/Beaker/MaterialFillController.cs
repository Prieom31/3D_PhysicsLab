using UnityEngine;
using UnityEngine.UI;

public class MaterialFillController : MonoBehaviour
{
    public string fillPropertyName = "_Fill"; // Replace with the actual property name in your shader
    public Slider fillSlider;
    public float minFillValue = 0f;
    public float maxFillValue = 1f;
    private Material material;

    private void Start()
    {
        // Get the material from the Renderer component attached to this GameObject
        Renderer renderer = GetComponent<Renderer>();
        material = renderer.material;

        // Add a listener to the slider's value change event
        fillSlider.onValueChanged.AddListener(OnFillSliderValueChanged);
    }

    private void OnFillSliderValueChanged(float fillValue)
    {
        // Clamp the fill value between 0 and 1
        fillValue = Mathf.Clamp(fillValue, minFillValue, maxFillValue);

        // Set the fill value on the material
        material.SetFloat(fillPropertyName, fillValue);
    }
}

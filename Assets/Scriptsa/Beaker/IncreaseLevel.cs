using UnityEngine;
using UnityEngine.UI; // Required when Using UI elements.

public class IncreaseLevel : MonoBehaviour
{
    public float IncreaseForce=0.01f;
    public Slider mainSlider; // Assign your slider gameobject to this variable in the Editor.
    public GameObject detector; // Assign your detector gameobject to this variable in the Editor.

    void OnTriggerEnter(Collider other)
    {
        // Check if the other collider has the tag "Sphere"
        if (other.CompareTag("Sphere"))
        {
            // Increase the slider value by 0.1f
            mainSlider.value += IncreaseForce;
        }

        
    }
}

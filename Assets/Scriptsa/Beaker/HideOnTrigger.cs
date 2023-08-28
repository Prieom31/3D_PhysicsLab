using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HideOnTrigger : MonoBehaviour
{
    /*public float IncreaseForce = 0.01f;*/
     // Assign your slider gameobject to this variable in the Editor.
    public GameObject detector; // Assign your detector gameobject to this variable in the Editor.
    public GameObject ToUp;
    public GameObject ToDown;

    void OnTriggerEnter(Collider other)
    {
        // Check if the other collider has the tag "Sphere"
        if (other.CompareTag("ToUp"))
        {
            // Increase the slider value by 0.1f
            ToUp.SetActive(false);
            ToDown.SetActive(true);
        }

        if (other.CompareTag("ToDown"))
        {
            // Increase the slider value by 0.1f
            ToUp.SetActive(true);
            ToDown.SetActive(false);
        }

    }
}

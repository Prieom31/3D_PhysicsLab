using UnityEngine;

public class HideShow : MonoBehaviour
{
    public GameObject targetObject;
    public float displayTime = 3f;

    private void Start()
    {
        targetObject.SetActive(true); // Make the object initially active

        Invoke("DeactivateObject", displayTime);
    }

    private void DeactivateObject()
    {
        targetObject.SetActive(false); // Deactivate the object after the specified display time
    }
}

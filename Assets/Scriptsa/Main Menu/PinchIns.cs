using UnityEngine;

public class PinchIns : MonoBehaviour
{
    public GameObject objectToShowHide;
    public float timeToShow = 5f;

    private bool isShowing = false;
    private float remainingTimeToShow = 0f;

    void Update()
    {
        if (isShowing)
        {
            remainingTimeToShow -= Time.deltaTime;
            if (remainingTimeToShow <= 0f)
            {
                objectToShowHide.SetActive(false);
                isShowing = false;
            }
        }
    }

    public void ShowObject()
    {
        objectToShowHide.SetActive(true);
        isShowing = true;
        remainingTimeToShow = timeToShow;
    }
}

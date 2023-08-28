using UnityEngine;

public class CollisionDetector : MonoBehaviour
{
    public bool isColliding = false;
    public GameObject ZoomTap;
    public GameObject SkipB;

    private void Update()
    {
        if (isColliding == false)
        {
            Invoke("HideZoom", 0.1f);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        isColliding = true;
        if (!ZoomTap.activeSelf && SkipB.activeSelf)
        {
            Invoke("ShowZoom", 2f);
        }
        else
        {
            Invoke("HideZoom", 0.1f);
        }
        Debug.Log("Collided");
    }

    private void OnCollisionExit(Collision collision)
    {
        isColliding = false;
        Invoke("HideZoom", 0.1f);
    }
    void ShowZoom()
    {
        ZoomTap.SetActive(true);
    }
    void HideZoom()
    {
        ZoomTap.SetActive(false);
    }
}

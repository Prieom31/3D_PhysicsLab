using UnityEngine;
using UnityEngine.UI;

public class CollisionController : MonoBehaviour
{
    public Slider slider;
    private bool isColliding;

    private void OnCollisionEnter(Collision collision)
    {
        isColliding = true;
    }

    public void EndCollision()
    {
        isColliding = false;
    }

    private void Update()
    {
        if (!isColliding)
        {
            slider.value += Time.deltaTime;
        }
    }
}

using UnityEngine;
using UnityEngine.UI;

public class PauseOnCollision : MonoBehaviour
{
    public Animator anim;
    public Slider slider;
    private float animSpeed;

    private void OnCollisionEnter(Collision collision)
    {
        animSpeed = anim.speed;
        anim.speed = 0;
        slider.interactable = false;
        Debug.Log("Collided");
    }

    private void OnCollisionExit(Collision collision)
    {
        anim.speed = animSpeed;
        slider.interactable = true;
    }
}
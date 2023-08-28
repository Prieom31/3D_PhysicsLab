using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OpenClose : MonoBehaviour

{
    private Slider mSlider;
    public GameObject ScrewGaudge;
    // Start is called before the first frame update
    void Start()
    {
        mSlider = GetComponent<Slider>();
    }
    public void OnZoom()
    {
        mSlider.interactable = false;
    }
    public void OffZoom()
    {
        mSlider.interactable = true;
    }
    // Update is called once per frame
    void Update()
    {

    }

    public void ApplyAnimation()
    {
        if (ScrewGaudge != null)
        {
            Animator animator = ScrewGaudge.GetComponent<Animator>();

            if (animator != null)
            {
                animator.SetFloat("TheSim", mSlider.value);
            }
        }
    }
}
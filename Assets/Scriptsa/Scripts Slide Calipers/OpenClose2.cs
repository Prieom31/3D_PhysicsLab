using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OpenClose2 : MonoBehaviour

{
    private Slider mSlider;
    public GameObject SlideCalipers;
    // Start is called before the first frame update
    void Start()
    {
        mSlider = GetComponent<Slider>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void ApplyAnimation()
    {
        if (SlideCalipers != null)
        {
            Animator animator = SlideCalipers.GetComponent<Animator>();

            if (animator != null)
            {
                animator.SetFloat("SlideSIm", mSlider.value);
            }
        }
    }
}
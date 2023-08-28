using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class STJTest : MonoBehaviour
{
    private Slider mSlider;
    public GameObject ScrewGaudge;
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
        if (ScrewGaudge != null)
        {
            Animator animator = ScrewGaudge.GetComponent<Animator>();

            if (animator != null)
            {
                animator.SetFloat("ControlBehave", mSlider.value);
            }
        }
    }
}
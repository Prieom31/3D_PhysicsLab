using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpriteONOff : MonoBehaviour
{

    public GameObject slideRtL;
    public GameObject slideLtR;
    public GameObject TapCube;
    public GameObject DragShow;
    public GameObject LineShow;
    public GameObject PlaceMent;
    public GameObject Dialog;
    public GameObject cubicButton;
    public GameObject cubic;


    public Slider mSlider;
    public float timeToShow = 1f;
    public float timeToShow1 = 5f;
    private bool isShowing = false;
    private bool dragShowing = false;
    private float remainingTimeToShow = 0f;
    private float remainingTimeToShow1 = 0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        
        if (isShowing && mSlider.value == 0 && !Dialog.activeSelf && !cubic.activeSelf)
        {
            slideLtR.SetActive(true);
            isShowing = false;
        }
        if (isShowing && !Dialog.activeSelf && mSlider.value!=0 && !cubic.activeSelf)
        {
            remainingTimeToShow -= Time.deltaTime;
            if (remainingTimeToShow <= 0f)
            {
                TapCube.SetActive(true);
                isShowing = false;
            }
        }

        if (dragShowing && !cubicButton.activeSelf && !Dialog.activeSelf && mSlider.value != 0)
        {
            remainingTimeToShow1 -= Time.deltaTime;
            if (remainingTimeToShow1 <= 4f)
            {
                DragShow.SetActive(true);
                dragShowing = false;
            }
        }
    }

    public void Showtutorial()
    {
        slideLtR.SetActive(true);
    }

    public void ShowtapHideSlide()
    {
        slideLtR.SetActive(false);
        TapCube.SetActive(false);
        isShowing = true;
        remainingTimeToShow = timeToShow;
    }

    public void ShowDragHideTap()
    {
        TapCube.SetActive(false);
        DragShow.SetActive(false);
        //LineShow.SetActive(true);
        //PlaceMent.SetActive(true);
        dragShowing = true;
        remainingTimeToShow1 = timeToShow1;
    }
}

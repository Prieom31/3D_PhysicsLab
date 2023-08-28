using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class resetpos : MonoBehaviour
{
    //private float startingFieldOfView;
    public GameObject Data1;
    public GameObject Data2;
    //public GameObject Ref;
    public Slider mSlider;
   // public Slider mSlider2;

    private Vector3 startingPosition1;
    private Vector3 startingPosition2;
    private Quaternion startingRotation1;
    private Quaternion startingRotation2;
    private float sliderValue;
    private float sliderValue2;

    // Start is called before the first frame update
    void Start()
    {
        sliderValue = mSlider.GetComponent<Slider>().value;
        //sliderValue2 = mSlider2.GetComponent<Slider>().value;
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void Awake()
    {
        //startingFieldOfView = Camera.main.fieldOfView;
        startingPosition1 = Data1.transform.position;
        startingPosition2 = Data2.transform.position;
        startingRotation1 = Data1.transform.rotation;
        startingRotation2 = Data2.transform.rotation;
        
    }

    public void ResetPos()
    {
        //Camera.main.fieldOfView = startingFieldOfView;
        Data1.transform.position = startingPosition1;
        Data2.transform.position = startingPosition2;
        Data1.transform.rotation = startingRotation1;
        Data2.transform.rotation = startingRotation2;
        mSlider.GetComponent<Slider>().value =sliderValue;
       // mSlider2.GetComponent<Slider>().value = sliderValue2;
    }


}
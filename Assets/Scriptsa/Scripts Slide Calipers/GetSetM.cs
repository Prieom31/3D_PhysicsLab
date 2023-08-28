using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GetSetM : MonoBehaviour
{
    public float o;
    private string inputL1;
    private string inputL2;
    private string inputL3;
    public Text updatetextW;
    public float a =25.4897f;
    public float b =8.7833f;
    public float c =5.5833f;
    private float defaultValue;
    public Text dialogBoxText;
    public GameObject dialogBox;
    public GameObject target;


    private Vector3 previousScale;

    // Start is called before the first frame update
    void Start()
    {
        //defaultValue = a * b * c;

        if (target != null)
        {
            previousScale = target.transform.localScale;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (target != null)
        {
            Vector3 currentScale = target.transform.localScale;

            float scaleDiffX = currentScale.x - previousScale.x;
            float scaleDiffY = currentScale.y - previousScale.y;
            float scaleDiffZ = currentScale.z - previousScale.z;

            a += (scaleDiffX*900.9009009009f);
            b += scaleDiffY;
            c += scaleDiffZ;

            defaultValue = a * b * c;

            previousScale = currentScale;
        }
    }


    public void readStringL1(string s)
    {
        inputL1 = s;
        Debug.Log(inputL1);
    }

    public void readStringL2(string q)
    {
        inputL2 = q;
        Debug.Log(inputL2);
    }

    public void readStringL3(string r)
    {
        inputL3 = r;
        Debug.Log(inputL3);
    }
    public void updateText()
    {
        o = (float.Parse(inputL1) * float.Parse(inputL2) * float.Parse(inputL3));
        updatetextW.text = o.ToString();

    }

    public void ShowPercentage()
    {
        float calculatedValue = float.Parse(inputL1) * float.Parse(inputL2) * float.Parse(inputL3);
        if (calculatedValue < defaultValue)
        {
            float percentage = (calculatedValue / defaultValue) * 100;
            string message = "Your calculated Volume is <b>" + calculatedValue + "mm³</b>" + "\n\nThe accuracy of your measured Volume is <b> " + percentage.ToString("F2") + "% </b>" + ".";
            ShowDialogBox(message);
        }
        else
        {
            float percentage =200.00f-( (calculatedValue / defaultValue) * 100);
            string message = "Your calculated Volume is <b>" + calculatedValue + "mm³</b>" + "\n\nThe accuracy of your measured Volume is <b> " + percentage.ToString("F2") + "% </b>" + ".";
            ShowDialogBox(message);
        }
        

       
    }

    private void ShowDialogBox(string message)
    {
        // Set the dialog box text
        dialogBoxText.text = message;

        // Show the dialog box
        dialogBox.SetActive(true);
    }

    public void HideDialogBox()
    {
        // Set the dialog box text

        // Show the dialog box
        dialogBox.SetActive(false);
    }


    //"\nThe actual volume is " + defaultValue.ToString("F3") +
}
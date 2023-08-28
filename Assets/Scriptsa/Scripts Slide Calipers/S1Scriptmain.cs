using TMPro;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class S1Scriptmain : MonoBehaviour
{
    public float a;
    public float? b;
    public float? c;
    public float? d;
    public float avg;


    private string input_L1;
    private string input_L2;
    private string input_L3;
 
    private string input_T11;
    private string input_T12;
    private string input_T13;


    public Text updatetext_S11;
    public Text updatetext_S12;
    public Text updatetext_S13;

    public Text updatetext_avg1;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void readString_L1(string s1)
    {
        input_L1 = s1;
        Debug.Log(input_L1);
    }
    public void readString_L2(string s2)
    {
        input_L2 = s2;
        Debug.Log(input_L2);
    }
    public void readString_L3(string s3)
    {
        input_L3 = s3;
        Debug.Log(input_L3);
    }


    public void readString_T11(string r)
    {
        input_T11 = r;
        Debug.Log(input_T11);
    }

    public void readString_T12(string w)
    {
        input_T12 = w;
        Debug.Log(input_T12);
    }

    public void readString_T13(string t)
    {
        input_T13 = t;
        Debug.Log(input_T13);
    }



    public void updateText_S11()
    {
        b = float.Parse(input_L1) + float.Parse(input_T11)*0.05f;
        updatetext_S11.text = b.ToString();
    }

    public void updateText_S12()
    {
        c = float.Parse(input_L2) + float.Parse(input_T12)*0.05f;
        updatetext_S12.text = c.ToString();
    }

    public void updateText_S13()
    {
        d = float.Parse(input_L3) + float.Parse(input_T13) * 0.05f;
        updatetext_S13.text = d.ToString();
    }

    /*    public void updateText_avg1()
        {
            float avg = (b + c + d) / 3.0f;
            updatetext_avg1.text = avg.ToString();
        }*/

    public void updateText_avg1()
    {
        int count = 0; // Counter to keep track of the number of available variables
        float sum = 0.0f; // Sum of the available variables

        if (b.HasValue)
        {
            sum += b.Value;
            count++;
        }

        if (c.HasValue)
        {
            sum += c.Value;
            count++;
        }

        if (d.HasValue)
        {
            sum += d.Value;
            count++;
        }

        float avg = (count > 0) ? (sum / count) : 0.0f; // Calculate average if at least one variable is available

        updatetext_avg1.text = avg.ToString();
    }


}
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class S1Script : MonoBehaviour
{
    public float a;
    public float b;
    public float c;
    public float d;
    public float avg;


    private string input_L1;
    private string input_H1;

    private string input_T11;
    private string input_T12;
    private string input_T13;


    public Text updatetext_Sin1;

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
    public void readString_L1(string s)
    {
        input_L1 = s;
        Debug.Log(input_L1);
    }

    public void readString_H1(string q)
    {
        input_H1 = q;
        Debug.Log(input_H1);
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

    public void updateText_Sin1()
    {
        a = Mathf.Asin(float.Parse(input_H1) / float.Parse(input_L1)) * Mathf.Rad2Deg;
        updatetext_Sin1.text = a.ToString();
    }

    public void updateText_S11()
    {
        b = float.Parse(input_L1) / float.Parse(input_T11);
        updatetext_S11.text = b.ToString();
    }

    public void updateText_S12()
    {
        c = float.Parse(input_L1) / float.Parse(input_T12);
        updatetext_S12.text = c.ToString();
    }

    public void updateText_S13()
    {
        d = float.Parse(input_L1) / float.Parse(input_T13);
        updatetext_S13.text = d.ToString();
    }

    public void updateText_avg1()
    {
       double avg = ( b+ c+ d) / 3.0;
        updatetext_avg1.text = avg.ToString();
    }
    
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GetSetMap : MonoBehaviour
{
    public float o;
    private string inputL1;
    private string inputL2;
    private string inputL3;
    public Text updatetextH;
    public Text updatetextH1;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

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
        o = (float.Parse(inputL1) / float.Parse(inputL2));
        updatetextH.text = o.ToString("F2");
    }
    public void updateText1()
    {
        
        updatetextH1.text = inputL1.ToString();
    }
}

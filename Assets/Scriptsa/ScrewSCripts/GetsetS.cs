using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GetsetS : MonoBehaviour
{
    public float o;
    public float z;
    private string inputL1;
    private string inputL2;
    private string inputL3;
    private string inputL4;
    private string inputL5;
    private string inputL6;
    public Text updatetextL;
    public Text updatetext2;
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

    public void readStringL4(string t)
    {
        inputL4 = t;
        Debug.Log(inputL4);
    }

    public void readStringL5(string u)
    {
        inputL5 = u;
        Debug.Log(inputL5);
    }

    public void readStringL6(string v)
    {
        inputL6 = v;
        Debug.Log(inputL6);
    }
    public void updateText()
    {
        o = (float.Parse(inputL1) + float.Parse(inputL2) + float.Parse(inputL3)+ float.Parse(inputL4) + float.Parse(inputL5) + float.Parse(inputL6));
        updatetextL.text = o.ToString();
    }
    public void updateText2()
    {
        o = (float.Parse(inputL1) + float.Parse(inputL2) + float.Parse(inputL3) + float.Parse(inputL4) + float.Parse(inputL5) + float.Parse(inputL6));
        z = (o / 6);
        updatetext2.text = z.ToString();
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class MeasureVol : MonoBehaviour
{
   // [SerializeField] GetsetS Diameter;//
    public Text Area;
    private string inputL1;
    private string inputL2;
    private string inputL3;

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
    public void UpdateMeasure()
    {
        if (inputL1 != null && inputL3 !=null)
        {
            float r = ((float.Parse(inputL1))/ (float.Parse(inputL3))) * 3.1416f * ((float.Parse(inputL2) * (float.Parse(inputL2))));
            Area.text = r.ToString();
        }
        else
        {
            float r = ( 3.1416f * ((float.Parse(inputL2) * (float.Parse(inputL2)))));
            Area.text = r.ToString();
        }
    }
}
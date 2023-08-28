using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class MeasureVo : MonoBehaviour
{
    [SerializeField] GetsetText Length;
    [SerializeField] Getset2 Width;
    [SerializeField] Getset3 Heigth;
    public Text Sum;


    public void UpdateMeasure()
    {
        float r = Length.o + Width.o + Heigth.o;
        Sum.text = r.ToString();

    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowHide : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject ourCubid;
    //public GameObject ourCylinder;
    public GameObject Sbutton;
    //public GameObject Cbutton;
    public GameObject selecLengthbtn;
    public GameObject selecWidthbtn;
    public GameObject selecHeigthbtn;
    public GameObject HText;
    public GameObject LengthDrop;
    public GameObject WidthDrop;
    public GameObject HeigthDrop;
    public GameObject Chart;
    public GameObject Scene;
    void Start()
    {
        selecLengthbtn.SetActive(false);
        selecWidthbtn.SetActive(false);
        ourCubid.SetActive(false);
        //ourCylinder.SetActive(false);
        selecHeigthbtn.SetActive(false);
        LengthDrop.SetActive(true);
        WidthDrop.SetActive(false);
        HeigthDrop.SetActive(false);
        Chart.SetActive(false);


    }
    public void showSpherhideButton()
    {
        ourCubid.SetActive(true);
        Sbutton.SetActive(false);
        //Cbutton.SetActive(false);
        HText.SetActive(false);
        selecLengthbtn.SetActive(true);
        selecWidthbtn.SetActive(true);
        selecHeigthbtn.SetActive(true);

    }

   /* public void showCylinderhideButton()
    {
        ourCylinder.SetActive(true);
        Sbutton.SetActive(false);
        Cbutton.SetActive(false);
        HText.SetActive(false);

    }*/


    public void LengthDropShow()
    {
        LengthDrop.SetActive(true);
        WidthDrop.SetActive(false);
        HeigthDrop.SetActive(false);

    }

public void WidthDropShow()
    {
        LengthDrop.SetActive(false);
        WidthDrop.SetActive(true);
        HeigthDrop.SetActive(false);

    }

public void HeigthDropShow()
    {
        LengthDrop.SetActive(false);
        WidthDrop.SetActive(false);
        HeigthDrop.SetActive(true);
    }

    public void LengthDropShow1()
    {
        LengthDrop.SetActive(true);
        WidthDrop.SetActive(true);
        HeigthDrop.SetActive(true);

    }
    public void ChartShow()
    {
        Chart.SetActive(true);
        Scene.SetActive(false);
    }

public void ChartHide()
    {
        Chart.SetActive(false);
        Scene.SetActive(true);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class TimeExample : MonoBehaviour
{
    public Text disvar;
    float val;
    bool str;
    // Start is called before the first frame update
    void Start()
    {
        val = 0;
        str = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (str)
        {
            val += Time.deltaTime;
        }
        disvar.text = val.ToString();
    }

    public void start()
    {
        str = true;
    }

    public void stop()
    {
        str = false;
    }

    public void reset()
    {
        str = false;
        val = 0;
    }
}

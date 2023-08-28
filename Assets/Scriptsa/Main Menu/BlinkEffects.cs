using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using TMPro;


public class BlinkEffects : MonoBehaviour
{

    public Color Color1;
    public Color Color2;
    public TextMeshProUGUI Text;


    public void Update()
    {
        FlashingText();
    }


    public void FlashingText()
    {
        Text.color = Color.Lerp(Color1, Color2, Mathf.PingPong(Time.time, 1));
    }



}

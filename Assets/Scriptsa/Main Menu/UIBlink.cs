using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UIBlink : MonoBehaviour
{
    public Image image;
    public Text myText;
    public TextMeshPro myText1;
    public float blinkDuration = 1f;
    public Color[] colors;

    private int colorIndex = 0;
    private float timer = 0f;

    void Update()
    {
        timer += Time.deltaTime;

        if (timer >= blinkDuration)
        {
            colorIndex = (colorIndex + 1) % colors.Length;
            timer = 0f;
        }

        float alpha = Mathf.PingPong(Time.time, blinkDuration) / blinkDuration;
        Color color = colors[colorIndex];
        color.a = alpha;

        image.color = color;
        myText.color = color;
        myText1.color = color;
    }
}

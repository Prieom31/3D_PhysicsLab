using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DistanceM : MonoBehaviour, IDataPersistence
{
    public TextMeshProUGUI DistanceText;
    public GameObject LowerIndicator;
    public GameObject HigherIndicator;
    public double Distance_;
    private int a = 0;
    public double real_distance;
    public float s = 1.82f;
    // Start is called before the first frame update
    public void LoadData(GameData data)
    {
        this.a = data.a;
    }

    public void SaveData(ref GameData data)
    {
        data.a = this.a;
    }

    void Start()
    {

    }



    // Update is called once per frame
    private void Update()
    {
        Distance_ = ((Vector2.Distance(LowerIndicator.transform.position, HigherIndicator.transform.position))*1000);
        real_distance = Distance_ / s;
        a = (int)real_distance;

        DistanceText.text = "" + a;

    }
}

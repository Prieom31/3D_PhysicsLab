using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DistanceScrew : MonoBehaviour, IDataPersistence
{
    public Text DistanceText;
    public GameObject Rular;
    public GameObject Vernier;
    public double Distance_;
    private float a = 0;
    public double real_distance;
    // Start is called before the first frame update
    public void LoadData(GameData data)
    {
        this.a = data.a;
    }

    public void SaveData(ref GameData data)
    {
        data.a = (int)this.a;
    }

    void Start()
    {

    }



    // Update is called once per frame
    private void Update()
    {
        Vector3 distanceVector = Rular.transform.position - Vernier.transform.position;
        float real_distance = distanceVector.magnitude * 1000;
        real_distance = (Mathf.Ceil(real_distance * 2f) / 2f)-0.5f;
        if (real_distance >=0.0f && real_distance < 25.5f)
        {
            DistanceText.text = "" + real_distance;
        }
    }

}
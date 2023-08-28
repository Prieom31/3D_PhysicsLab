using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Behave2 : MonoBehaviour
{
    public Behaviour scriptA;
    public GameObject Lock;
    public GameObject UnLock;
    // Start is called before the first frame update
    void Start()
    {
        UnLock.SetActive(false);
        scriptA.enabled = false;
    }

    public void EnableScript()
    {
        scriptA.enabled = true;
        Lock.SetActive(false);
        UnLock.SetActive(true);

    }

    public void DisableScript()
    {
        scriptA.enabled = false;
        Lock.SetActive(true);
        UnLock.SetActive(false);
    }
    // Update is called once per frame
    void Update()
    {

    }
}
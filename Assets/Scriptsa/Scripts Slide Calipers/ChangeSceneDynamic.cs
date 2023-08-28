using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class ChangeSceneDynamic : MonoBehaviour
{
    // Start is called before the first frame update
   // public GameObject obj;

// public GameObject Ui;
    //public GameObject Ui2;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Pauseandtransfer()
    {
        if (SceneManager.GetActiveScene().buildIndex == 0)
            Application.LoadLevelAdditive(1);
        else
            Application.LoadLevelAdditive(0);
    }
    public void SceneTransfer() 
    {
        if (SceneManager.GetActiveScene().buildIndex == 0)
            SceneManager.LoadScene(1);
        else
            SceneManager.LoadScene(0);
    }
    public void Loadscene1()
    {
        SceneManager.LoadScene(1);
       // Ui.SetActive(false);
       
  

    }
    public void Loadscene0()
    { 
        SceneManager.LoadScene(0);
       // Ui2.SetActive(false);
      
    }

}

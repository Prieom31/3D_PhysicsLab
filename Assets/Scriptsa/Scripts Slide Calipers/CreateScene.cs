using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class CreateScene : MonoBehaviour
{
    private string nextSceneName0 = "Main Ui";
    private string nextSceneName= "Main Ui2";
    private string nextSceneName1= "SlideCalipersScene";
    private string nextSceneName2= "ScrewGAudgeSim";
    private string nextSceneName3 = "Scroll_ball";
    private string nextSceneName4 = "Mapchong";
    private string nextSceneName5 = "Example_2_Controled Flipping";
    private string nextSceneName6 = "Ex5";
    // name of the scene to load

    private void Start()
    {

    }
    public void LoadNextScene()
    {
        // Load the next scene
        SceneManager.LoadScene(nextSceneName);
    }

    public void LoadNextScene0()
    {
        // Load the next scene
        SceneManager.LoadScene(nextSceneName0);
    }

    public void LoadNextScene1()
    {
        // Load the next scene
        SceneManager.LoadScene(nextSceneName1);
    }
    public void LoadNextScene2()
    {
        // Load the next scene
        SceneManager.LoadScene(nextSceneName2);
    }
    public void LoadNextScene3()
    {
        // Load the next scene
        SceneManager.LoadScene(nextSceneName3);
    }
    public void LoadNextScene4()
    {
        // Load the next scene
        SceneManager.LoadScene(nextSceneName4);
    }

    public void LoadNextScene5()
    {
        // Load the next scene
        SceneManager.LoadScene(nextSceneName5);
    }

    public void LoadNextScene6()
    {
        // Load the next scene
        SceneManager.LoadScene(nextSceneName6);
    }
    public void Exitgame()
    {
        Application.Quit();
    }
}
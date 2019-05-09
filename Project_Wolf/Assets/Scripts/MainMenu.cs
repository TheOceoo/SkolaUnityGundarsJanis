using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; //tiek izmantots lai piekļūtu ainu funkcijām

public class MainMenu : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void StartGame()
    {
        SceneManager.LoadScene(1);
    }
    public void ExitGame()
    {
        Application.Quit();
    }
    public void toMain()
    {
        SceneManager.UnloadSceneAsync("Main");
        SceneManager.LoadScene(0);
    }

}
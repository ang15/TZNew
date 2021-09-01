using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController:MonoBehaviour
{
    void Start()
    {
        Time.timeScale = 0;
       
    }

    void Update()
    {

    }
    public void ExitGame()
    {
        Debug.Log("Игра закончилась");
        Application.Quit();
    }
    public void Restart()
    {
        SceneManager.LoadScene("SampleScene");
    }

    public void Starts()
    {
        Time.timeScale = 1;
        UiPanel.TrueOrFalse = false;
    }


}


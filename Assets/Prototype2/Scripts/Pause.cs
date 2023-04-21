using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Pause : MonoBehaviour
{
    public GameObject pauseUI;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            pauseUI.SetActive(true);
            Time.timeScale = 0f;
            Debug.Log("Down");
        }
    }
    public void Resume()
    {
        pauseUI.SetActive(false);
        Time.timeScale = 1f; 
    }

    public void Restart()
    {
        SceneManager.LoadScene("PrototypeTwo");
        LeavesCount.countGone = 0;
        LeavesCount.countSaved = 0;
        Time.timeScale = 0f;
    }

    public void Restart3()
    {
        SceneManager.LoadScene("PrototypeThree");
        Time.timeScale = 0f;
    }


    public void Menu()
    {
        SceneManager.LoadScene("Start");
        LeavesCount.countGone = 0;
        LeavesCount.countSaved = 0;
        Time.timeScale = 1f;
    }

    public void QuitTheGame()
    {
        Application.Quit();
        Debug.Log("Quit");
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NewMenu : MonoBehaviour
{
    public void Addition()
    {
        SceneManager.LoadScene("Addition");
        Time.timeScale = 1;
    }

    public void Subtraction()
    {
        SceneManager.LoadScene("Subtraction");
        Time.timeScale = 1;
    }

    public void Mutltiplication()
    {
        SceneManager.LoadScene("Multiplication");
        Time.timeScale = 1;
    }

    public void Divison()
    {
        SceneManager.LoadScene("Divison");
        Time.timeScale = 1;
    }

    public void Menu()
    {
        SceneManager.LoadScene("Start");
        Time.timeScale = 1;
    }
}

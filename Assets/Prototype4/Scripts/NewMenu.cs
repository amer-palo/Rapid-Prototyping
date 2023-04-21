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
        ScoreCounter.correctAnswer = 0;
        ScoreCounter.incorrectAnswer = 0;
    }

    public void Subtraction()
    {
        SceneManager.LoadScene("Subtraction");
        Time.timeScale = 1;
        ScoreCounter.correctAnswer = 0;
        ScoreCounter.incorrectAnswer = 0;
    }

    public void Mutltiplication()
    {
        SceneManager.LoadScene("Multiplication");
        Time.timeScale = 1;
        ScoreCounter.correctAnswer = 0;
        ScoreCounter.incorrectAnswer = 0;
    }

    public void Menu()
    {
        SceneManager.LoadScene("Start");
        Time.timeScale = 1;
    }
}

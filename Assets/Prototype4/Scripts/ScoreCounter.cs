using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoreCounter : MonoBehaviour
{
    public TextMeshProUGUI correctText;
    public TextMeshProUGUI incorrectText;
    public static int correctAnswer;
    public static int incorrectAnswer;

    public GameObject winUI;
    public GameObject loseUI;

    void Update()
    {
        correctText.GetComponent<TextMeshProUGUI>().text = "Answers Correct: " + correctAnswer + "/20";
        incorrectText.GetComponent<TextMeshProUGUI>().text = "Answers Incorrect: " + incorrectAnswer + "/5";

        if(correctAnswer == 20)
        {
            winUI.SetActive(true);
        }

        if(incorrectAnswer == 5)
        {
            loseUI.SetActive(true);
        }
    }
}

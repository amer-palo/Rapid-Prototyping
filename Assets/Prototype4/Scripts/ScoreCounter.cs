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

    void Update()
    {
        correctText.GetComponent<TextMeshProUGUI>().text = "Answers Correct: " + correctAnswer + "/20";
        incorrectText.GetComponent<TextMeshProUGUI>().text = "Answers Incorrect: " + incorrectAnswer + "/5";
    }
}

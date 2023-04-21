using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class AdditionManager : MonoBehaviour
{
    public TextMeshProUGUI firstNumber;
    public TextMeshProUGUI secondNumber;
    public TextMeshProUGUI firstAnswer;
    public TextMeshProUGUI secondAnswer;

    public List<int> mathList = new List<int>();

    public int randomFirstNumber;
    public int randomSecondNumber;

    private int firstNumberProblem;
    private int secondNumberProblem;
    private int answerOne;
    private int answerTwo;
    private int displayRandomAnswer;
    private int randomAnswerPlacement;
    public int currentAnswer;
    public TextMeshProUGUI rightOrWrong;

    

    private void Start()
    {
        DisplayMathProblem();
    }


    public void DisplayMathProblem()
    {
        randomFirstNumber = Random.Range(0, mathList.Count + 1);
        randomSecondNumber = Random.Range(0, mathList.Count + 1);

        firstNumberProblem = randomFirstNumber;
        secondNumberProblem = randomSecondNumber;
        answerOne = firstNumberProblem + secondNumberProblem;
        displayRandomAnswer = Random.Range(0, 2);
        if (displayRandomAnswer == 0)
        {
            answerTwo = answerOne + Random.Range(1, 5);
        }
        else
        {
            answerTwo = answerOne - Random.Range(1, 5);
        }
        firstNumber.text = "" + firstNumberProblem;
        secondNumber.text = "" + secondNumberProblem;
        randomAnswerPlacement = Random.Range(0, 2);
        if (randomAnswerPlacement == 0)
        {
            firstAnswer.text = "" + answerOne;
            secondAnswer.text = "" + answerTwo;
            currentAnswer = 0;
        }
        else
        {
            firstAnswer.text = "" + answerTwo;
            secondAnswer.text = "" + answerOne;
            currentAnswer = 1;
        }
    }

    public void ButtonAnwserOne()
    {
        if(currentAnswer == 0)
        {
            rightOrWrong.enabled = true;
            rightOrWrong.color = Color.green;
            rightOrWrong.text = ("Correct");
            Invoke("TurnOffText", 1);
            ScoreCounter.correctAnswer += 1;
        }
        else
        {
            rightOrWrong.enabled = true;
            rightOrWrong.color = Color.red;
            rightOrWrong.text = ("Incorrect");
            Invoke("TurnOffText", 1);
            ScoreCounter.incorrectAnswer += 1;
        }
    }

    public void ButtonAnswerTwo()
    {
        if (currentAnswer == 1)
        {
            rightOrWrong.enabled = true;
            rightOrWrong.color = Color.green;
            rightOrWrong.text = ("Correct");
            Invoke("TurnOffText", 1);
            ScoreCounter.correctAnswer += 1;
            
        }
        else
        {
            rightOrWrong.enabled = true;
            rightOrWrong.color = Color.red;
            rightOrWrong.text = ("Incorrect");
            Invoke("TurnOffText", 1);
            ScoreCounter.incorrectAnswer += 1;
        }
    }

    public void TurnOffText()
    {
        if(rightOrWrong != null)
        {
            rightOrWrong.enabled = false;
        }

        DisplayMathProblem();
    }
}

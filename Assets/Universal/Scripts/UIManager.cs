using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UIManager : GameBehaviour<UIManager>
{
    public TMP_Text scoreText;
    public TMP_Text timerText;
    public int score = 0;
    public int scoreBonus = 50;
    public Ease scoreEase;

    void Start()
    {
        scoreText.text = score.ToString();
    }

    private void Update()
    {
        timerText.text = _TIMER.GetTime().ToString("F3");
    }
    public void TweenScore()
   {
        DOTween.To(() => score, x => score = x, score + scoreBonus, 1).SetEase(scoreEase).OnUpdate(() =>
        {
            scoreText.text = "Score: " + score.ToString();
        });
   }
}

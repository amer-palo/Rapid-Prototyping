using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UIManager : GameBehaviour<UIManager>
{
    public TMP_Text scoreText;
    public int score = 0;
    public int scoreBonus = 50;
    public Ease scoreEase;

    void Start()
    {
        scoreText.text = score.ToString();
    }

   public void TweenScore()
   {
        DOTween.To(() => score, x => score = x, score + scoreBonus, 1).SetEase(scoreEase).OnUpdate(() =>
        {
            scoreText.text = "Score: " + score.ToString();
        });
   }
}

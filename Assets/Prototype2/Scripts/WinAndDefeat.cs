using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WinAndDefeat : MonoBehaviour
{
    public GameObject defeatUI;
    public GameObject winUI;

    void Update()
    {
        if(LeavesCount.countGone == 3)
        {
            Time.timeScale = 0f;
            defeatUI.SetActive(true);
        }

        if(LeavesCount.countSaved == 20)
        {
            Time.timeScale = 0f;
            winUI.SetActive(true);
        }
    }
}

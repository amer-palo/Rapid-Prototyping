using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RulesUI : MonoBehaviour
{
    public GameObject rulesText;
    public GameObject button;
    public void Continue()
    {
        rulesText.SetActive(false);
        button.SetActive(false);
    }
}

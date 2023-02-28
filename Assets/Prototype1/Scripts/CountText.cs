using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CountText : MonoBehaviour
{
    public TextMeshProUGUI countText;
    public static int count;

    void Update()
    {
        countText.GetComponent<TextMeshProUGUI>().text = "Stars: " + count;
    }     
    
}

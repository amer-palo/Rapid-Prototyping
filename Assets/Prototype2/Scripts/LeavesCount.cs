using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class LeavesCount : MonoBehaviour
{
    public TextMeshProUGUI leavesGoneText;
    public TextMeshProUGUI leavesSavedText;
    public static int countGone;
    public static int countSaved;

    void Update()
    {
        leavesGoneText.GetComponent<TextMeshProUGUI>().text = "Leaves unsaved: " + countGone;
        leavesSavedText.GetComponent<TextMeshProUGUI>().text = "Leaves saved: " + countSaved;
    }

}

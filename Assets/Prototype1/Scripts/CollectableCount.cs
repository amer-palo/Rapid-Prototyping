using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CollectableCount : MonoBehaviour
{
    public TextMeshProUGUI countText;
    public int count;
    void Start()
    {
        countText.text = "Stars Collected: 0";
        countText = GetComponent<TextMeshProUGUI>();
    }

    void OnTriggerEnter(Collider other)
    {
        count += 1;
        countText.GetComponent<TextMeshProUGUI>().text = "Stars Collected: " + count;
        Destroy(gameObject);
    }
   
}

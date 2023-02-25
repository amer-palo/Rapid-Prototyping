using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Collectables : MonoBehaviour
{
    public static event Action OnCollected;
    public TextMeshProUGUI countText;
    public int count;
    void Update()
    {
        transform.localRotation = Quaternion.Euler(180f, Time.time * 100f, 0);
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            OnCollected?.Invoke();
            Destroy(gameObject);
            count += 1;
            countText.GetComponent<TextMeshProUGUI>().text = "Stars Collected: " + count;
        }
    }
}

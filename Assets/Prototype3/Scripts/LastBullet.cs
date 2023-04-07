using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LastBullet : MonoBehaviour
{
    public GameObject lastBullet;
    public GameObject winUI;
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Death"))
        {
            Destroy((lastBullet));
            winUI.SetActive(true);
            Time.timeScale = 0;
        }
    }
}

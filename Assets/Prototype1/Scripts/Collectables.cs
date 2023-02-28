using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Collectables : MonoBehaviour
{
    private int count;
    public GameObject barrier;
    public GameObject barrier2;
    void Update()
    {
        transform.localRotation = Quaternion.Euler(180f, Time.time * 100f, 0);
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            CountText.count += 1;
            Destroy(gameObject);
        }

        if (CountText.count == 8)
        {
            barrier.SetActive(false);
            barrier2.SetActive(false);
        }
      
    }
}
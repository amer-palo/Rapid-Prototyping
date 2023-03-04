using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Collectables : MonoBehaviour
{
    public int count;
    public GameObject barrier;
    
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

        if (CountText.count == 7)
        {
            barrier.SetActive(false);
        }
      
    }
}

using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class Leaves : MonoBehaviour
{
    //public int count;

    void OnMouseDown()
    {
        Destroy(gameObject);
        LeavesCount.countSaved += 1;
    }
    void Update()
    {
        //transform.localRotation = Quaternion.Euler(180f, Time.time * 100f, 0);
        
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Destroy"))
        {
            LeavesCount.countGone += 1;
        }
    }
}

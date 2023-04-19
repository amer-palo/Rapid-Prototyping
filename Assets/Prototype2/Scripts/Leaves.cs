using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class Leaves : MonoBehaviour
{
    void OnMouseDown()
    {
        Destroy(gameObject);
        LeavesCount.countSaved += 1;
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Destroy"))
        {
            LeavesCount.countGone += 1;
        }
    }
}

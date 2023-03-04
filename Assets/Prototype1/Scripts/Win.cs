using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Win : MonoBehaviour
{
    public GameObject winUI;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Death"))
        {
            winUI.SetActive(true);
        }
    }
}

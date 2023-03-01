using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class EndingSequence : MonoBehaviour
{

    void OnTriggerEnter(Collider other)
    {
       if(other.CompareTag("Player"))
       {
            GameObject.Find("Boss").GetComponent<Enemy>().enabled = false;
            GameObject.Find("Player").GetComponent<PlayerController>().enabled = false;
            GameObject.Find("Focal Point").GetComponent<RotateCamera>().enabled = false;
            StartCoroutine(PauseScripts());
       }
    }

    IEnumerator PauseScripts()
    {
        yield return new WaitForSeconds(3);
        GameObject.Find("Boss").GetComponent<Enemy>().enabled = true;
        GameObject.Find("Player").GetComponent<PlayerController>().enabled = true;
        GameObject.Find("Focal Point").GetComponent<RotateCamera>().enabled = true;
    }
}

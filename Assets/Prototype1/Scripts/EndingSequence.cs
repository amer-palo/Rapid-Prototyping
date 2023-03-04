using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class EndingSequence : MonoBehaviour
{
    public GameObject bossText;
    public GameObject colliderWall;
    void OnTriggerEnter(Collider other)
    {
       if(other.CompareTag("Player"))
       {
            bossText.SetActive(true);
            GameObject.Find("Boss").GetComponent<Enemy>().enabled = false;
            GameObject.Find("Player").GetComponent<PlayerController>().enabled = false;
            //GameObject.Find("Focal Point").GetComponent<RotateCamera>().enabled = false;
            StartCoroutine(PauseScripts());
            colliderWall.transform.position = new Vector3(100, 100, 100);
       }
    }

    IEnumerator PauseScripts()
    {
        yield return new WaitForSeconds(3);
        GameObject.Find("Boss").GetComponent<Enemy>().enabled = true;
        GameObject.Find("Player").GetComponent<PlayerController>().enabled = true;
        bossText.SetActive(false);
        //GameObject.Find("Focal Point").GetComponent<RotateCamera>().enabled = true;
    }

    public void Menu()
    {
        SceneManager.LoadScene("Start");
    }

    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("Quit");
    }
}

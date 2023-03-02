using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartMenu : MonoBehaviour
{
   public void PrototypeOne()
   {
        SceneManager.LoadScene("Prototype 1");
        Time.timeScale = 1;
   }

    public void Quit()
    {
        Application.Quit();
        Debug.Log("Quit");
    }
}

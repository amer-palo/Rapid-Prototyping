using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartMenu : MonoBehaviour
{
    public Collectables collectables;
   public void PrototypeOne()
   {
        //collectables.count = 0;
        SceneManager.LoadScene("Prototype 1");
        Time.timeScale = 1;
   }

    public void Quit()
    {
        Application.Quit();
        Debug.Log("Quit");
    }
}

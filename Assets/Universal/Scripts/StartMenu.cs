using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartMenu : MonoBehaviour
{
    //public Collectables collectables;
   public void PrototypeOne()
   {
        //collectables.count = 0;
        CountText.count = 0; 
        SceneManager.LoadScene("Prototype 1");
        Time.timeScale = 1;
   }

    public void PrototypeTwo()
    {
        SceneManager.LoadScene("PrototypeTwo");
        Time.timeScale = 0;
    }

    public void PrototypeThree()
    {
        SceneManager.LoadScene("PrototypeThree");
        Time.timeScale = 0;
    }

    public void PrototypeFour()
    {
        SceneManager.LoadScene("Prototype 4");
        Time.timeScale = 1;
    }

    public void PrototypeFive()
    {
        SceneManager.LoadScene("Prototype 5");
        Time.timeScale = 1;
    }

    public void Quit()
    {
        Application.Quit();
        Debug.Log("Quit");
    }
}

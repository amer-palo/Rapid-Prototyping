using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TwoDController : MonoBehaviour
{
    public Rigidbody2D player;
    public float speed = 5.0f;
    public GameObject deathScreen;
    public int keyCount;
    public GameObject door;
    public GameObject doorTwo;
    public GameObject winnerUI;
    public GameObject rulesUI;
    void Start()
    {
        
    }

    void Update()
    {
        if(Input.GetKey(KeyCode.A))
        {
            //player.AddForce(new Vector2(-speed, 0));
            transform.Translate(-speed * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey(KeyCode.D))
        {
            //player.AddForce(new Vector2(speed, 0));
            transform.Translate(speed * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey(KeyCode.W))
        {
            //player.AddForce(new Vector2(0, speed));
            transform.Translate(0, speed * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey(KeyCode.S))
        {
            //player.AddForce(new Vector2(0, -speed));
            transform.Translate(0, -speed * Time.deltaTime, 0, 0);
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            //player.AddForce(new Vector2(-speed, 0));
            transform.Translate(-speed * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            //player.AddForce(new Vector2(speed, 0));
            transform.Translate(speed * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            //player.AddForce(new Vector2(0, speed));
            transform.Translate(0, speed * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            //player.AddForce(new Vector2(0, -speed));
            transform.Translate(0, -speed * Time.deltaTime, 0, 0);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Key")
        {
            Destroy(collision.gameObject);
            keyCount += 1;
            Debug.Log("Keys: " + keyCount);
        }

        if(keyCount == 3)
        {
            door.SetActive(false);
            doorTwo.SetActive(false);
        }

        if (collision.gameObject.tag == "Enemy")
        {
            Destroy(gameObject);
            Time.timeScale = 0;
            deathScreen.SetActive(true);
        }

        if(collision.gameObject.tag == "Finish")
        {
            SceneManager.LoadScene("Level 2");
        }

        if (collision.gameObject.tag == "End")
        {
            Time.timeScale = 0;
            winnerUI.SetActive(true);
        }
    }

    public void RulesScreen()
    {
        rulesUI.SetActive(false);
        Time.timeScale = 1f;
    }
}

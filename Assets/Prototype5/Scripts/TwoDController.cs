using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TwoDController : MonoBehaviour
{
    public Rigidbody2D player;
    public float speed = 5.0f;
    void Start()
    {
        
    }

    void Update()
    {
        if(Input.GetKey(KeyCode.A))
        {
            player.AddForce(new Vector2(-speed, 0));
            //transform.Translate(-speed * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey(KeyCode.D))
        {
            player.AddForce(new Vector2(speed, 0));
            //transform.Translate(speed * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey(KeyCode.W))
        {
            player.AddForce(new Vector2(0, speed));
            //transform.Translate(0, speed * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey(KeyCode.S))
        {
            player.AddForce(new Vector2(0, -speed));
            //transform.Translate(0, -speed * Time.deltaTime, 0, 0);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Key")
        {
            Destroy(collision.gameObject);
        }

        if(collision.gameObject.tag == "Enemy")
        {
            Destroy(gameObject);
        }
    }
}

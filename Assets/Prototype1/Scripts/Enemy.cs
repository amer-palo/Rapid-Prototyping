using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float enemySpeed = 2;
    private Rigidbody enemyRB;
    private GameObject player;
    void Start()
    {
        enemySpeed = 2f;
        enemyRB = GetComponent<Rigidbody>();
        player = GameObject.Find("Player");
    }

   
    void Update()
    {
        Vector3 lookDirection = (player.transform.position - transform.position).normalized;
        enemyRB.AddForce(lookDirection * enemySpeed);

        if (transform.position.y < -10)
        {
            Destroy(gameObject);
        }
    }
}

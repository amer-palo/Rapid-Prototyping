using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public GameObject player;
    public GameObject bullet;
    public GameObject deathUI;
    public float bulletSpeed;

    private void Update()
    {
        transform.Translate(Vector3.forward * bulletSpeed * Time.deltaTime);

    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Death"))
        {
            Destroy((bullet));
        }

        if (other.CompareTag("Player"))
        {
            Debug.Log("Dead");
            Destroy((player));
            deathUI.SetActive(true);
            Time.timeScale = 0;
        }
    }


}

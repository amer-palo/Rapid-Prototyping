using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlowTime : MonoBehaviour
{
    public float timeSpeed = 1;
    public GameObject slowdownIndicator;
    public bool gotPowerup;

    void Update()
    {
        slowdownIndicator.transform.position = transform.position + new Vector3(0, 0.2f, 0);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            gotPowerup = true;
            Destroy(gameObject);
            slowdownIndicator.gameObject.SetActive(true);
            StartCoroutine(SlowDownTimeCountdownRoutine());
            Time.timeScale = timeSpeed;
        }
    }
    

    IEnumerator SlowDownTimeCountdownRoutine()
    {
        yield return new WaitForSeconds(5);
        slowdownIndicator.gameObject.SetActive(false);
        gotPowerup = false;
    }
}

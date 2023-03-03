using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    private Rigidbody playerRB;
    public float speed = 8.0f;
    private GameObject focalPoint;
    public bool hasPowerup;
    private float powerupStrength = 15.0f;
    public GameObject powerupIndicator;
    public float jumpForce = 2.0f;
    private bool onGround = true;
    public float fallMultiplier = 2.0f;
    public GameObject deathUI;

    public GameObject pauseEnemyIndicator;
    public bool gotPowerup;
    void Start()
    {
        playerRB = GetComponent<Rigidbody>();
        focalPoint = GameObject.Find("Focal Point");
    }

    // Update is called once per frame
    void Update()
    {
        pauseEnemyIndicator.transform.position = transform.position + new Vector3(0, 0.2f, 0);
        powerupIndicator.transform.position = transform.position + new Vector3(0, -0.5f, 0);
        //float forwardInput = Input.GetAxis("Vertical"); 
        //playerRB.AddForce(focalPoint.transform.forward * speed * forwardInput);

        if (Input.GetKeyDown(KeyCode.Space) == true && onGround == true)
        {
            onGround = false;
            playerRB.AddForce(Vector3.up * jumpForce, ForceMode.VelocityChange);
        }
    }

    private void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal"); float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

        playerRB.AddForce(movement * speed);
        if (playerRB.velocity.y < 0)
        {
            playerRB.velocity += Vector3.up * Physics.gravity.y * fallMultiplier * Time.deltaTime;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Powerup"))
        {
            hasPowerup = true;
            Destroy(other.gameObject);
            powerupIndicator.gameObject.SetActive(true);
            StartCoroutine(PowerUpCountdownRoutine());
        }

        if (other.CompareTag("PauseEnemy"))
        {
            gotPowerup = true;
            GameObject.Find("Enemy").GetComponent<Enemy>().enabled = false;
            Destroy(other.gameObject);
            pauseEnemyIndicator.gameObject.SetActive(true);
            StartCoroutine(PauseEnemyCountdownRoutine());
        }

        if (other.CompareTag("Death"))
        {
            SceneManager.LoadScene("Death");
            Time.timeScale = 0;
        }
    }
     
    IEnumerator PowerUpCountdownRoutine()
    {
        yield return new WaitForSeconds(7);
        powerupIndicator.gameObject.SetActive(false);
        hasPowerup = false;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Enemy") && hasPowerup)
        {
            Rigidbody enemyRigidbody = collision.gameObject.GetComponent<Rigidbody>();
            Vector3 awayFromPlayer = (collision.gameObject.transform.position - transform.position);
            Debug.Log("Collide with " + collision.gameObject.name + " with powerup set to " + hasPowerup);
            enemyRigidbody.AddForce(awayFromPlayer * powerupStrength, ForceMode.Impulse);
        }
    }

    IEnumerator PauseEnemyCountdownRoutine()
    {
        yield return new WaitForSeconds(3);
        GameObject.Find("Enemy").GetComponent<Enemy>().enabled = true;
        pauseEnemyIndicator.gameObject.SetActive(false);
        gotPowerup = false;
    }

    private void OnCollisionStay(Collision collision)
    {
        onGround = true;
    }

    private void OnCollisionExit(Collision collision)
    {
        onGround = false;
    }
}

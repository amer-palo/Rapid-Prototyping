using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlowLeaves : MonoBehaviour
{
    void OnMouseDown()
    {
        Destroy(gameObject);
        Time.timeScale = 0.5f;
        StartCoroutine(SlowLeavesDown());
    }


    IEnumerator SlowLeavesDown()
    {
        yield return new WaitForSeconds(1);
        Time.timeScale = 1f;
        Debug.Log("Start");
    }
}

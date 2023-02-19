using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateCamera : MonoBehaviour
{
    public float rotationSpeed;

    
    void Update()
    {
        float horiztonalInput = Input.GetAxis("Horizontal");
        transform.Rotate(Vector3.up, horiztonalInput * rotationSpeed * Time.deltaTime);
    }
}

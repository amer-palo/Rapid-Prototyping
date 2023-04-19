using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Apples : MonoBehaviour
{
    void OnMouseDown()
    {
        Destroy(gameObject);
        LeavesCount.countGone -= 1;
    }
}

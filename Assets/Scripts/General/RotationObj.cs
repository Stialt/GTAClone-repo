using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationObj : MonoBehaviour
{

    public int rotateSpeed = 4;
    
    void Update()
    {
        transform.Rotate(0, rotateSpeed * Time.timeScale, 0);
    }
}

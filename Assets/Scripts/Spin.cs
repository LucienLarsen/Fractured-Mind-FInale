using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spin : MonoBehaviour
{
    public float rotateSpeed = 10f;
    public float rotationObject = 10f;
 
    void Update()
    {
        transform.localRotation = Quaternion.Euler(rotationObject, Time.time * rotateSpeed, 0);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Outofbound : MonoBehaviour
{
    public Vector3 Respawn;
    void Start()
    {
        Respawn = transform.position;
    }
    
    void OnTriggerEnter(Collider collider)
    {
        if (collider.tag == "Respawn")
        {
            transform.GetComponent<CharacterController>().enabled = false;
            transform.position = Respawn;
            transform.GetComponent<CharacterController>().enabled = true;
            
        }
        if (collider.tag == "Checkpoint")
        {
            Respawn = transform.position;
        }
    }

}

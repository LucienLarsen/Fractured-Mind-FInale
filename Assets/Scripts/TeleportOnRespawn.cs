using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportOnRespawn : MonoBehaviour
{
    private Vector3 originalPosition;

    void Start()
    {
        // Store the object's initial position
        originalPosition = transform.position;
    }

    void OnTriggerEnter(Collider collider)
    {
        if (collider.tag == "Respawn")
        {
            // Reset the position to the original position
            transform.position = originalPosition;
        }
    }
}

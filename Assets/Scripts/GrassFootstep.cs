using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*public class GrassFootstep : MonoBehaviour

{
    public AudioSource grassFootstepsSound, grassSprintSound;
    public Transform player;
    
    void Update()
    {
        CharacterController playerController = player.GetComponent<CharacterController>();
        
        // Check if player is grounded
        if (playerController.isGrounded)
        {
            // Check if movement keys are pressed
            if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.D))
            {
                // Check if sprint key is pressed
                if (Input.GetKey(KeyCode.LeftShift))
                {
                    if (!grassSprintSound.isPlaying)
                    {
                        grassFootstepsSound.Stop(); // Stop regular footsteps if playing
                        grassSprintSound.Play();
                    }
                }
                else
                {
                    if (!grassFootstepsSound.isPlaying)
                    {
                        grassSprintSound.Stop(); // Stop sprint footsteps if playing
                        grassFootstepsSound.Play();
                    }
                }
            }
            else
            {
                // Stop all audio if no movement keys are pressed
                grassFootstepsSound.Stop();
                grassSprintSound.Stop();
            }
        }
        else
        {
            // Stop all audio if player is not grounded
            grassFootstepsSound.Stop();
            grassSprintSound.Stop();
        }
    }
}*/

public class GrassFootstep : MonoBehaviour
{
    public AudioSource grassFootstepsSound, grassSprintSound;
    public AudioSource plasticFootstepsSound, plasticSprintSound;
    public Transform player;
    public float raycastDistance = 1.1f; // Adjust based on player's height

    void Update()
    {
        CharacterController playerController = player.GetComponent<CharacterController>();

        // Check if the player is grounded
        if (playerController.isGrounded && IsOnGrass())
        {
            // Check if movement keys are pressed
            if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.D))
            {
                // Check if sprint key is pressed
                if (Input.GetKey(KeyCode.LeftShift))
                {
                    if (!grassSprintSound.isPlaying)
                    {
                        grassFootstepsSound.Stop(); // Stop regular footsteps if playing
                        grassSprintSound.Play();
                    }
                }
                else
                {
                    if (!grassFootstepsSound.isPlaying)
                    {
                        grassSprintSound.Stop(); // Stop sprint footsteps if playing
                        grassFootstepsSound.Play();
                    }
                }
            }
            else
            {
                // Stop all audio if no movement keys are pressed
                grassFootstepsSound.Stop();
                grassSprintSound.Stop();
            }
        }
        else
        {
            // Stop all audio if player is not grounded or not on grass
            grassFootstepsSound.Stop();
            grassSprintSound.Stop();
        }

        if (playerController.isGrounded && IsOnPlastic())
        {
            // Check if movement keys are pressed
            if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.D))
            {
                // Check if sprint key is pressed
                if (Input.GetKey(KeyCode.LeftShift))
                {
                    if (!plasticSprintSound.isPlaying)
                    {
                        plasticFootstepsSound.Stop(); // Stop regular footsteps if playing
                        plasticSprintSound.Play();
                    }
                }
                else
                {
                    if (!plasticFootstepsSound.isPlaying)
                    {
                        plasticSprintSound.Stop(); // Stop sprint footsteps if playing
                        plasticFootstepsSound.Play();
                    }
                }
            }
            else
            {
                // Stop all audio if no movement keys are pressed
                plasticFootstepsSound.Stop();
                plasticSprintSound.Stop();
            }
        }
        else
        {
            // Stop all audio if player is not grounded or not on grass
            plasticFootstepsSound.Stop();
            plasticSprintSound.Stop();
        }
    }

    // Check if the player is on an object with the "grass" tag
    private bool IsOnGrass()
    {
        RaycastHit hit;
        // Cast a ray downward from the player's position
        if (Physics.Raycast(player.position, Vector3.down, out hit, raycastDistance))
        {
            // Return true if the object hit by the ray has the "grass" tag
            return hit.collider.CompareTag("grass");
        }
        return false;
    }
    private bool IsOnPlastic()
    {
        RaycastHit hit;
        // Cast a ray downward from the player's position
        if (Physics.Raycast(player.position, Vector3.down, out hit, raycastDistance))
        {
            // Return true if the object hit by the ray has the "grass" tag
            return hit.collider.CompareTag("plastic");
        }
        return false;
    }
}

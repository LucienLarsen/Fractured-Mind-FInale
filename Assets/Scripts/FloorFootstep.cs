using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloorFootstep : MonoBehaviour
{
    public AudioSource floorFootstepsSound, floorSprintSound;
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
                    if (!floorSprintSound.isPlaying)
                    {
                        floorFootstepsSound.Stop(); // Stop regular footsteps if playing
                        floorSprintSound.Play();
                    }
                }
                else
                {
                    if (!floorFootstepsSound.isPlaying)
                    {
                        floorSprintSound.Stop(); // Stop sprint footsteps if playing
                        floorFootstepsSound.Play();
                    }
                }
            }
            else
            {
                // Stop all audio if no movement keys are pressed
                floorFootstepsSound.Stop();
                floorSprintSound.Stop();
            }
        }
        else
        {
            // Stop all audio if player is not grounded
            floorFootstepsSound.Stop();
            floorSprintSound.Stop();
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*public class RoadFootstep : MonoBehaviour
{
    public AudioSource roadFootstepsSound, roadSprintSound;
    public Transform player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        CharacterController playerController = player.GetComponent<CharacterController>();
        if (playerController.isGrounded)
        {
            if(Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.D))
            {
                if (Input.GetKey(KeyCode.LeftShift))
                {
                    roadFootstepsSound.enabled = false;
                    roadSprintSound.enabled = true;
                }
                else
                {
                    roadFootstepsSound.enabled = true;
                    roadSprintSound.enabled = false;
                }
            }
            else
            {
                roadFootstepsSound.enabled = false;
                roadSprintSound.enabled = false;
            }
        }
        
    }
}*/

public class RoadFootstep : MonoBehaviour
{
    public AudioSource roadFootstepsSound, roadSprintSound;
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
                    if (!roadSprintSound.isPlaying)
                    {
                        roadFootstepsSound.Stop(); // Stop regular footsteps if playing
                        roadSprintSound.Play();
                    }
                }
                else
                {
                    if (!roadFootstepsSound.isPlaying)
                    {
                        roadSprintSound.Stop(); // Stop sprint footsteps if playing
                        roadFootstepsSound.Play();
                    }
                }
            }
            else
            {
                // Stop all audio if no movement keys are pressed
                roadFootstepsSound.Stop();
                roadSprintSound.Stop();
            }
        }
        else
        {
            // Stop all audio if player is not grounded
            roadFootstepsSound.Stop();
            roadSprintSound.Stop();
        }
    }
}

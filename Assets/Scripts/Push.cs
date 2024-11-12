using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// DENNE KODEN SKAL PÅ OBJEKTET DU KAN RØRE PÅ!!
/*public class Push : MonoBehaviour
{
    public Transform player;         // Reference to the player transform
    public Transform playerCam;      // Reference to the camera transform
    private bool hasPlayer = false;  // Check if player is close enough
    private bool beingCarried = false; // Check if the object is being carried
    private bool touched = false;     // Check if the object has been touched (not currently used in the code)
    public GameObject PickUpText;

    void Start()
    {
        PickUpText.SetActive(false);
    }

    void Update()
    {
        // Check distance to the player
        float dist = Vector3.Distance(gameObject.transform.position, player.position);
        hasPlayer = dist <= 1.5f;
        RaycastHit hitinfo;
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        // Get the CharacterController component from the player
        CharacterController playerController = player.GetComponent<CharacterController>();

        // Check if the player is grounded and is close enough to the object
        if (Physics.Raycast(ray, out hitinfo) && (hasPlayer && playerController != null) && (playerController.isGrounded) && (Input.GetKey(KeyCode.F)))
        {
            if(hitinfo.transform.tag == "Pickupable")
            {
            GetComponent<Rigidbody>().isKinematic = true;
            transform.parent = playerCam;
            beingCarried = true;
            }
        }
        else
        {
            GetComponent<Rigidbody>().isKinematic = false;
            transform.parent = null;
            beingCarried = false;            
        }
    }
}*/

// DENNE KODEN SKAL PÅ OBJEKTET DU KAN RØRE PÅ!!
public class Push : MonoBehaviour
{
    public Transform player;         // Reference to the player transform
    public Transform playerCam;      // Reference to the camera transform
    private bool hasPlayer = false;  // Check if player is close enough
    private bool beingCarried = false; // Check if the object is being carried
    private bool touched = false;     // Check if the object has been touched (not currently used in the code)



    void Start()
    {

    }

    public void PickUp()
    {
                // Check distance to the player
        float dist = Vector3.Distance(gameObject.transform.position, player.position);
        hasPlayer = dist <= 1.5f;
        RaycastHit hitinfo;
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        // Get the CharacterController component from the player
        CharacterController playerController = player.GetComponent<CharacterController>();

        // Check if the player is grounded and is close enough to the object
        if (Physics.Raycast(ray, out hitinfo) && (hasPlayer && playerController != null) && (playerController.isGrounded))
        {
            {
                if(hitinfo.transform.tag == "Pickupable")
                {

                    GetComponent<Rigidbody>().isKinematic = true;
                    transform.parent = playerCam;
                    beingCarried = true;
                    player.gameObject.GetComponent<Player>().isObjectHeld = true;
                }
            }
            
        }
    }
    public void LetGo()
    {
        GetComponent<Rigidbody>().isKinematic = false;
        transform.parent = null;
        beingCarried = false; 
        player.gameObject.GetComponent<Player>().isObjectHeld = false;           
    }
}
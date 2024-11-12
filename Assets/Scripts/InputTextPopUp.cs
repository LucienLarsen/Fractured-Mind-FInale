using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

/*public class InputTextPopUp : MonoBehaviour
{
    public Transform player;         // Reference to the player transform
    public Transform playerCam;      // Reference to the camera transform
    private bool hasPlayer = false;  // Check if player is close enough
    private bool beingCarried = false; // Check if the object is being carried
    private bool touched = false;     // Check if the object has been touched (not currently used in the code)
    // Start is called before the first frame update
    [SerializeField] private TextMeshProUGUI inputText;
    [SerializeField] private string pickUpInputText;
    [SerializeField] private string readNoteInputText;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float dist = Vector3.Distance(gameObject.transform.position, player.position);
        hasPlayer = dist <= 1.5f;
        RaycastHit hitinfo;
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        CharacterController playerController = player.GetComponent<CharacterController>();
        {
            if (Physics.Raycast(ray, out hitinfo) && (hasPlayer && playerController != null) && (playerController.isGrounded))
            {
            
                if(hitinfo.transform.tag == "Pickupable")
                {
                    inputText.enabled = true;
                    inputText.text = pickUpInputText;
                }
                if(hitinfo.transform.tag == "Note")
                {
                    inputText.enabled = true;
                    inputText.text = readNoteInputText;
                }
            
            }
            else
            {
                inputText.enabled = false;
            }
        }
        
    }
}*/

public class InputTextPopUp : MonoBehaviour
{
    public Transform player;         // Reference to the player transform
    public Transform playerCam;      // Reference to the camera transform
    private bool hasPlayer = false;  // Check if player is close enough
    private bool beingCarried = false; // Check if the object is being carried
    private bool touched = false;     // Check if the object has been touched (not currently used in the code)
    // Start is called before the first frame update
    [SerializeField] private TextMeshProUGUI inputText;
    [SerializeField] private string pickUpInputText;
    [SerializeField] private string readNoteInputText;
    float interactionDistance = 2.0f; // Adjust this value as needed

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float dist = Vector3.Distance(gameObject.transform.position, player.position);
        hasPlayer = dist <= 1.5f;
        RaycastHit hitinfo;
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        CharacterController playerController = player.GetComponent<CharacterController>();
        {
            if (Physics.Raycast(ray, out hitinfo) && (hasPlayer && playerController != null) && (playerController.isGrounded))
            {
                // Calculate distance to the interactable object
                float distanceToInteractable = Vector3.Distance(playerController.transform.position, hitinfo.transform.position);

                // Check if the player is within interaction distance
                if (distanceToInteractable <= interactionDistance)
                    {
                        // If the object is "Pickupable"
                        if (hitinfo.transform.tag == "Pickupable")
                        {
                            inputText.enabled = true;
                            inputText.text = pickUpInputText;
                        }
                            // If the object is a "Note"
                        else if (hitinfo.transform.tag == "Note")
                        {
                            inputText.enabled = true;
                            inputText.text = readNoteInputText;
                        }
                    }
                else
                    {
                         // Hide inputText if out of range
                        inputText.enabled = false;
                    }
            }
        }
        
    }
}
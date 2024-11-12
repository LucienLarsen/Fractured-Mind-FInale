
using Unity.VisualScripting;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] float mouseSensitivity = 4f;
    float movementSpeed;
    [SerializeField] float walkingSpeed = 3f;
    [SerializeField] float runningSpeed = 6f;
    [SerializeField] float pushingSpeed = 2f;
    [SerializeField] float crouchingSpeed = 2f;
    [SerializeField] float jumpSpeed = 5f;
    [SerializeField] float mass = 1f;
    [SerializeField] Transform cameraTransform;
    
    CharacterController controller;
    Vector3 velocity;
    Vector2 look;
    [SerializeField] GameEvent pressedF;
    [SerializeField] GameEvent letGoF;
    public int playerState;
    [SerializeField] PlayerInput playerInput;
    public bool isObjectHeld;
    public AudioSource jumpSound;
    public Transform player;

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        movementSpeed = walkingSpeed;
    }

    void Update()
    {
        UpdateGravity();
        UpdateMovement();
        UpdateLook();
        PressingF();
        LettingGoF();
    }

    void Awake()
    {
        controller = GetComponent<CharacterController>();
    }
    void UpdateGravity()
    {
        var gravity = Physics.gravity * mass * Time.deltaTime;
        velocity.y = controller.isGrounded ? -1f : velocity.y + gravity.y;

    }
    void UpdateMovement()
    {
        var x = Input.GetAxis("Horizontal");
        var y = Input.GetAxis("Vertical");

        var input = new Vector3();
        input += transform.forward * y;
        input += transform.right * x;
        input = Vector3.ClampMagnitude(input, 1f);

        if (Input.GetButtonDown("Jump") && controller.isGrounded)
        {
            letGoF.Raise();
            velocity.y += jumpSpeed;
            jumpSound.Play();
        }
        if (playerState == 0 && playerInput.sprintPress)
        {
            movementSpeed = runningSpeed;
            playerState = 1;
        }
        if (playerState == 1 && playerInput.sprintLetGo)
        {
            movementSpeed = walkingSpeed;
            playerState = 0;
        }
        if (playerState == 0 && playerInput.crouchPress || playerState == 1 && playerInput.crouchPress)
        {
            movementSpeed = crouchingSpeed;
            playerState = 2;
        }
        if (playerState == 2 && playerInput.crouchLetGo)
        {
            movementSpeed = walkingSpeed;
            playerState = 0;
        }


        controller.Move((input * movementSpeed + velocity) * Time.deltaTime);
    }
    void UpdateLook()
    {
        look.x += Input.GetAxis("Mouse X");
        look.y += Input.GetAxis("Mouse Y");

        look.y = Mathf.Clamp(look.y, -89f, 89f);

        cameraTransform.localRotation = Quaternion.Euler(-look.y, 0, 0);
        transform.localRotation = Quaternion.Euler(0, look.x, 0);
    }
    void PressingF()
    {
        if(Input.GetKeyDown(KeyCode.F))
        {
            pressedF.Raise();
        }
    }
    void LettingGoF()
    {
        if(Input.GetKeyUp(KeyCode.F))
        {
            letGoF.Raise();
        }
    }
}
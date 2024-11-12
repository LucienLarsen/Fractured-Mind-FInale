using UnityEngine;


public class ClimbingScript : MonoBehaviour
{
    public Transform Player;
    bool inside = false;
    public float speedUpDown = 3.2f;
    public Player FPSInput;
    [SerializeField] Player player;

    void Start()
    {
        FPSInput = GetComponent<Player>();
        inside = false;
    }

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Ladder" && player.gameObject.GetComponent<Player>().isObjectHeld == false)
        {
            FPSInput.enabled = false;
            inside = !inside;
        }
    }

    void OnTriggerExit(Collider col)
    {
        if (col.gameObject.tag == "Ladder")
        {
            FPSInput.enabled = true;
            inside = !inside;
        }
    }

    void Update()
    {
        if (inside == true && Input.GetKey("w"))
        {
            Player.transform.position += Vector3.up / speedUpDown;
        }

        if (inside == true && Input.GetKey("s"))
        {
            Player.transform.position += Vector3.down / speedUpDown;
        }
    }
}
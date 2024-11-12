using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    public bool sprintPress;
    public bool sprintLetGo;
    public bool crouchPress;
    public bool crouchLetGo;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        sprintPress = Input.GetKeyDown(KeyCode.LeftShift);
        sprintLetGo = Input.GetKeyUp(KeyCode.LeftShift);
        crouchPress = Input.GetKeyDown(KeyCode.LeftControl);
        crouchLetGo = Input.GetKeyUp(KeyCode.LeftControl);
    }
}
 
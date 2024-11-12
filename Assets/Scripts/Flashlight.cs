using System.Collections; 
using System.Collections.Generic; 
using UnityEngine; 
 
public class Flashlight : MonoBehaviour 
{ 
    [SerializeField] GameObject FlashlightLight; 
    private bool FlashlightActive = false; 
    //Start is called before the first frame update 
    void Start() 
    { 
        FlashlightLight.gameObject.SetActive(false); 
    } 
 
 
 
    // Update is called once per frame 
    void Update() 
    { 
         
        if (Input.GetKeyDown(KeyCode.Q)) 
        { 
             
            FlashlightActive = !FlashlightActive; 
        } 
        if (FlashlightActive == true) 
        { 
            FlashlightLight.gameObject.SetActive(true); 
            //FlashlightActive = true; 
        } 
        if (FlashlightActive == false) 
        { 
            FlashlightLight.gameObject.SetActive(false); 
            //FlashlightActive = false; 
        } 
    } 
} 
 
    //bool Isflashlighton; 
    /*void Update() 
    { 
        if (Input.GetKeyDown(KeyCode.Q)) 
        { 
            Debug.Log("wasd"); 
            FlashlightActive = !FlashlightActive; 
        } 
        if (FlashlightActive == true) 
        { 
            gameObject.SetActive(true); 
            //FlashlightActive = true; 
        } 
        if (FlashlightActive == false) 
        { 
            gameObject.SetActive(false); 
            //FlashlightActive = false; 
        } 
 
    } 
 
 
}*/ 

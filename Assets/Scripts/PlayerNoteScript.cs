using System.Collections; 
using System.Collections.Generic; 
using UnityEngine; 
 
public class PlayerNoteScript : MonoBehaviour 
{ 
    private NoteScript activeNote; 

    // Start is called before the first frame update 
    void Start() 
    { 

    } 
 
    // Update is called once per frame 
    void Update() 
     
    { 
        if (activeNote) 
        { 
            if (Input.GetKeyDown("e")) 
            { 
                activeNote.ToggleNote(); 
            } 
        } 
    } 
 
    private void OnTriggerEnter(Collider col) 
    { 
        if (col.gameObject.tag == "Note") 
        { 
            col.gameObject.TryGetComponent(out activeNote); 
        } 
    } 
 
    private void OnTriggerExit(Collider col) 
    { 
        if (col.gameObject.tag == "Note") 
        { 
            if (activeNote.GetNoteStatus()) 
                activeNote.ToggleNote(); 
            activeNote = null; 
        } 
 
    } 
 
} 
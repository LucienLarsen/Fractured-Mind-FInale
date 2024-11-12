using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrayOfPartymembers : MonoBehaviour
{
   
    public string[] partyMembers = new string[3];
    public int index = 0;
    public List<GameObject> list = new List<GameObject> ();
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("party member: " + partyMembers[index]);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

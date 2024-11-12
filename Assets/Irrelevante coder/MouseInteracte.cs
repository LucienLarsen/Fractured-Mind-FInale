using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseInteracte : MonoBehaviour
{
    

    // Update is called once per frame
    void Update()
    {
        RaycastHit hitinfo;
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if(Physics.Raycast(ray, out hitinfo) && Input.GetKeyDown(KeyCode.Mouse0))
        {
            if(hitinfo.transform.tag == "Enemy")
            {
                Debug.Log("Enemy hit!");
                //hitinfo.transform.gameObject.SetActive(false);
                hitinfo.transform.GetComponent<EnemyHealthDamage>().Takedamage();
                
            }
        }
    }
}

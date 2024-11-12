using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickups : MonoBehaviour
{
/// Jonas sin
    public enum PickupType {Key, };
    public PickupType type;

    [SerializeField] GameObject _pickupEffect;

    void OnTriggerEnter(Collider collider)
    {
        if (collider.tag == "Player")
        {
            GetPickedUp(collider.gameObject);
        }
    }

    public void GetPickedUp(GameObject theOneWhoPickedMeUp)
    {
        
        Destroy(gameObject);
    }
}

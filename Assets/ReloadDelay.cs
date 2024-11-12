using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReloadDelay : MonoBehaviour
{
    private int maxAmmoAmount = 200;
    private int inMagazine = 30;
    private bool emptyClip = false;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && emptyClip == false)
        {
            Debug.Log("Shot fired!");
            inMagazine = inMagazine - 1;
            if (inMagazine == 0)
            {
                emptyClip = true;
            }
        }
        if (Input.GetKeyDown(KeyCode.R))
        {
            StartCoroutine(Reloading());
            maxAmmoAmount -= inMagazine;
        }

    }
    private IEnumerator Reloading()
    {
        print("Reloading!");
        yield return new WaitForSeconds(3);
        emptyClip = false;
        inMagazine = 30;
        print("Ready for action ");
    }
}

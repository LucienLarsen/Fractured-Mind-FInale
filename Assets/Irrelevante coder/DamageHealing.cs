using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageHealing : MonoBehaviour
{
    private int playerHealthAmount = 10;
    
    // Start is called before the first frame update
    void Start()
    {
        //takeDamageOverTime();
        StartCoroutine(HealingOverTime());

    }
    private void takeDamageOverTime () 
    { 
       while (playerHealthAmount > 10) 
        { 
        playerHealthAmount = playerHealthAmount - 5;
        Debug.Log("Health: "+ playerHealthAmount);
        }
        Debug.Log("Super low on health! Need healing!");
    }
    private IEnumerator HealingOverTime()
    {
        while (playerHealthAmount < 100)
        {
            yield return new WaitForSeconds(2);
            playerHealthAmount = playerHealthAmount + 5;
            Debug.Log("Health: " + playerHealthAmount);
        }
        Debug.Log("Full health!");
    }
}



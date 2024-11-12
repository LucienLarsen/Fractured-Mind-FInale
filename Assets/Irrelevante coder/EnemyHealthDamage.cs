using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealthDamage : MonoBehaviour
{
    public int enemyHealth = 100;
    public int damageTaken = 10;

  public void Takedamage()
    {
        enemyHealth = enemyHealth - damageTaken;
        Debug.Log("current health : " +  enemyHealth);
        if (enemyHealth > 0)
        {
        }
    }
}

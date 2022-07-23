using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour
{
    int health = 100;

    public void TakeDamage(int damage) {

        Debug.Log(gameObject.name + " ----> damage taken " + damage);
        if ((health - damage)<=0)
        {
            Debug.Log("Dead!");
            Destroy(gameObject);
        }
        else
        {
            
            health -= damage;
            Debug.Log("Current health = " + health);
        }
    
    }

}

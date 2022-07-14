using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class physic_2 : MonoBehaviour
{

    // 1 -> Rigidbody collision
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "ball_2")
        {
            Debug.Log("Rigidbody!");
        }
        else
        {
            Debug.Log("Rigidbody");
        }
    }


    // 2 -> Collider trigger collision

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "ball_2")
        {
            Debug.Log("Collider!");
        }
        else
        {
            Debug.Log("Collider");
        }
    }

}

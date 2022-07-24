using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class character_motion_2_1 : MonoBehaviour
{
    float moveH;
    float moveV;
    float jump;
    float rotX;

    private void FixedUpdate()
    {
        moveH = Input.GetAxis("Horizontal");
        moveV = Input.GetAxis("Vertical");
        jump = Input.GetAxis("Jump");

        transform.Translate(new Vector3(moveH, jump, moveV) * 5 * Time.deltaTime);  
    }
}

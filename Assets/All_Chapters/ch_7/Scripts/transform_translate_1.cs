using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class transform_translate_1 : MonoBehaviour
{
    float speed = 5f;

    void Start()
    {
        Debug.Log("\nObject position : " + transform.position);
        Debug.Log("\nObject rotation : " + transform.rotation);
        Debug.Log("\nObject localScale : " + transform.localScale);

        Debug.Log("\nObject position x : " + transform.position.x);
        Debug.Log("\nObject position y : " + transform.position.y);
        Debug.Log("\nObject position z : " + transform.position.z);
    }


    void Update()
    {
        //transform.Translate(Vector3.right * speed * Time.deltaTime);
        transform.Translate(new Vector3 (1f,0f,0f) * speed * Time.deltaTime); 
    }


}

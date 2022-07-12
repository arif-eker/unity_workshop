using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class get_components_in_parent_4_2 : MonoBehaviour
{

    SphereCollider sphereCol;
    Rigidbody rgdBody;
    TextMesh txt;

    void Start()
    {
        
        rgdBody = GetComponentInParent<Rigidbody>();
        rgdBody.drag = 2;
        Debug.Log("\nParent Name : " + rgdBody.gameObject.name);

        txt = GetComponentInParent<TextMesh>();
        txt.tabSize = 10;
        Debug.Log("\nParent Name : " + txt.gameObject.name);


        // can't possible
        //sphereCol = GetComponentInParent<SphereCollider>();
        //sphereCol.enabled = false;

    }

}

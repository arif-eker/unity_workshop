using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class methods_3 : MonoBehaviour
{
    public Transform secObj;
    public Transform thirdObj;

    public GameObject child;
    void Start()
    {
        
    }


    void Update()
    {


        // 1
        //transform.Rotate(new Vector3(1f,0f,0f) * 10f, Space.Self);
        //secObj.Rotate(new Vector3(1f,0f,0f)*10f, Space.World);
        //thirdObj.Rotate(new Vector3(1f,0f,0f)*10f, Space.Self);

        //transform.Rotate(10f, 0f, 0f, Space.Self);
        //secObj.Rotate(10f, 0f, 0f, Space.World);
        //thirdObj.Rotate(10f, 0f, 0f, Space.Self);


        // 2
        //transform.RotateAround(new Vector3(3f,1f,0f), Vector3.forward, 5f);
        //Debug.DrawLine(transform.position, new Vector3(3f, 1f, 0f), Color.blue);


        // 3
        //transform.LookAt(secObj, Vector3.up);

        // 4 
        //Debug.Log("\nPosition : "+child.transform.position);
        //Debug.Log("\nLocal Position : " + child.transform.localPosition);


        // 5
        
        Debug.Log(transform.GetChild(0).name);
        Debug.Log(transform.GetChild(1).name);


    }




}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class get_components_in_children_4_1 : MonoBehaviour
{

    AudioSource audioSrc;
    Rigidbody rgdBody;
    Transform [] transforms;
    

    void Start()
    {
        
        audioSrc = GetComponentInChildren<AudioSource>();
        audioSrc.enabled = false;
        Debug.Log("\nAudio Source Component Children name : " + audioSrc.gameObject.name);

        rgdBody = GetComponentInChildren<Rigidbody>();
        rgdBody.mass = 5;
        Debug.Log("\nRigidBody Component Children name : "+rgdBody.gameObject.name);

        

        //transforms = GetComponentsInChildren<Transform>();
        //foreach (var trs in transforms)
        //{
        //    Debug.Log(trs.gameObject.name);
        //}

    }




}

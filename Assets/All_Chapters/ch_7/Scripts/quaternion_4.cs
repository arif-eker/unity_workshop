using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class quaternion_4 : MonoBehaviour
{
    public Transform target;
    void Start()
    {
        
    }


    void Update()
    {
        // 1
        //Vector3 dir = target.position - transform.position;
        //transform.rotation = Quaternion.LookRotation(dir,Vector3.up);  // like transform.LookAt()


        // 2
        //float q_angle = Quaternion.Angle(target.rotation, transform.rotation);
        //Debug.Log("quaternion angle : " + q_angle);

        // 3
        //transform.rotation = Quaternion.Inverse(target.rotation);


        // 4
        //target.rotation = Quaternion.FromToRotation(Vector3.up, target.forward);

        // 5
        target.rotation = Quaternion.identity; // =====> target.rotation = 0,0,0

    }



}

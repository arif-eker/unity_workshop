using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class methods_2 : MonoBehaviour
{
    public Transform base_pos;
    public Transform target_pos;    

    float start_time;
    void Start()
    {

        //Debug.Log(Vector3.Magnitude(new Vector3(0f,2f,1f))); // ---> 2.23f

        //Debug.Log(Vector3.Magnitude(transform.position));
        //Debug.Log(Vector3.SqrMagnitude(new Vector3(1f, 2f, 1f))); // ----> 6f

        start_time = Time.time;

    }


    void Update()
    {
        // 2
        Vector3 vector = target_pos.position - base_pos.position;
        float angle = Vector3.Angle(vector, base_pos.forward);
        Debug.Log("\nAngle : " + angle);

        // 3
        float distance = Vector3.Distance(base_pos.position, target_pos.position);
        Debug.Log("Distance : " + distance);
        //Debug.Log(Vector3.Magnitude(target_pos.position - base_pos.position)); >>>>  distance = Magnitude (I think)


        // 4
        //base_pos.position = Vector3.Lerp(base_pos.position, target_pos.position, Time.time * .1f);
        base_pos.position = Vector3.Lerp(base_pos.position, target_pos.position, (Time.time - start_time) * .1f); // both codes do the same thing


    }


}

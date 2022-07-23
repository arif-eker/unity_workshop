using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class raycast_1 : MonoBehaviour
{

    public GameObject character;
    public Transform gun;
    public GameObject bullet;


    private void FixedUpdate()
    {

        character.transform.Translate(new Vector3(Input.GetAxis("Horizontal"), 0f, Input.GetAxis("Vertical")) * 5 * Time.deltaTime);
        RaycastHit hitInfo;

        //if (Physics.Raycast(gun.position, gun.forward, out hitInfo))
        if (Physics.Raycast(gun.position, gun.TransformDirection(Vector3.forward), out hitInfo))
        {
            //Debug.DrawRay(gun.position, gun.forward * hitInfo.distance, Color.red);
            Debug.DrawRay(gun.position, gun.TransformDirection(Vector3.forward) * hitInfo.distance, Color.red);
            //Debug.Log("Target Name : " + hitInfo.transform.name);
            //Debug.Log("Distance : " + hitInfo.distance);
            //Debug.Log("Target Coordinate : " + hitInfo.point);

        }
        else
        {
            //Debug.DrawRay(gun.position, gun.forward * 20, Color.green);
            Debug.DrawRay(gun.position, gun.TransformDirection(Vector3.forward) * 200, Color.green);
        }
    }


    private void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Instantiate(bullet,gun.position, Quaternion.identity);
        }
    }


}

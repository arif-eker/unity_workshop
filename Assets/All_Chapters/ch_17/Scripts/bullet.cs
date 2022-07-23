using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{
    float start_time;
    Vector3 start_pos;
    public GameObject impact_img;


    void Start()
    {
        start_time = Time.time;
        Destroy(gameObject, 4f);
        start_pos = transform.position;
    }

    void Update()
    {
        transform.Translate(Vector3.forward * 25 * Time.deltaTime); // 100 meters/second
        //Debug.Log("Life time : " + (Time.time - start_time) + "   Distance : " + Vector3.Distance(start_pos, transform.position));
    }

    private void OnCollisionEnter(Collision collision)
    {

        if (collision.rigidbody)
        {
            Debug.Log("Collision time : " + (Time.time - start_time));
            collision.gameObject.GetComponent<enemy>().TakeDamage(25);
            //Instantiate(impact_img, collision.transform.position, Quaternion.identity);

            Instantiate(impact_img, collision.GetContact(0).point, Quaternion.identity);
            Destroy(gameObject);

        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class find_gameobject_5 : MonoBehaviour
{

    GameObject obj;

    public GameObject publicGameObj; // 5
    void Start()
    {
        // 1
        GameObject.Find("Martin").GetComponent<martin_5_1>().age = 36; // martin_5_1 ---> script
        GameObject.Find("Martin").GetComponent<martin_5_1>().company = "Amazon";


        // 2
        obj =  GameObject.Find("John/Melissa");
        obj.GetComponent<BoxCollider>().enabled = false;



        // 3
        GameObject respawnObj = GameObject.FindWithTag("Respawn"); // Find the last gameobject that received the corresponding tag
        Debug.Log(respawnObj.name);
        //respawnObj.GetComponent<SphereCollider>().enabled = false;

        GameObject[] respawnObjs = GameObject.FindGameObjectsWithTag("Respawn");
        foreach (var obj in respawnObjs)
        {
            Debug.Log("\nGameObject name (Tag = Respawn) " + obj.gameObject.name);
        }

        // GameObject.FindWithTag > GameObject.Find


        // 4
        //transform.Find("John").GetComponent<BoxCollider>().enabled= false; // throw error
        transform.Find("controller_child").GetComponent<BoxCollider>().enabled= false; // true version, no error

        //transform.Find("controller_child_child").GetComponent<BoxCollider>().enabled= false; // throw error
        transform.Find("controller_child/controller_child_child").GetComponent<BoxCollider>().enabled = false; // true version, no error


        // 5
        Debug.Log("Public GameObject name : "+ publicGameObj.name);



        // 6 
        Camera camera = (Camera)FindObjectOfType(typeof(Camera));
        Debug.Log(camera.name);

        Light light = FindObjectOfType<Light>();
        Debug.Log(light.name);
        Debug.Log("Light off");
        //light.GetComponent<Light>().enabled = false;
        //light.enabled = false;


        // 7 
        GameObject respawnObj2 = GameObject.FindWithTag("Respawn");
        if (respawnObj2.tag == "Respawn")
        {
            Debug.Log("Tag is Respawn");
        }

        if (respawnObj2.CompareTag("Respawn"))
        {
            Debug.Log("Tag is Respawn");
        }
        // compareTag > condition use (==) 


        // 8
        Rigidbody myRigid = respawnObj2.AddComponent<Rigidbody>() as Rigidbody;
        myRigid.mass = 20;
    }


}

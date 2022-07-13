using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class instantiate_5 : MonoBehaviour
{

    public GameObject instantiate_obj;
    IEnumerator instantiateFunc;

    void Start()
    {
        //Instantiate(instantiate_obj, new Vector3(1f, 1f, 1f), Quaternion.Euler(30f, 0f, 0f));
        //Instantiate(instantiate_obj, new Vector3(4f, 1f, 1f), Quaternion.identity);

        //GameObject cube = Instantiate(instantiate_obj, new Vector3(1f, 1f, 1f), Quaternion.identity);
        //cube.name = "New_Cube";

        instantiateFunc = InstantiateGameObject(2f);
        StartCoroutine(instantiateFunc);
        
    }


    IEnumerator InstantiateGameObject(float time)
    {
        while (true)
        {
            Debug.Log("Creating prefab game object");
            Instantiate(instantiate_obj, new Vector3(1f, 1f, 1f), Quaternion.identity);

            Debug.Log("Wait 2 secs --- Time : " + Time.time);
            yield return new WaitForSeconds(time);
        }
        
    }


}

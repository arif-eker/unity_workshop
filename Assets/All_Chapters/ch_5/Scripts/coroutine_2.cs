using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coroutine_2 : MonoBehaviour
{


    public float reloadTime;
    IEnumerator my_coroutine;

    void Start()
    {
        //StartCoroutine(MyCoroutine()); // 1

        //StartCoroutine(MyCoroutine(reloadTime)); // 2

        my_coroutine = MyCoroutine(reloadTime); // 3
        StartCoroutine(my_coroutine);

        StartCoroutine(SecondCoroutine(my_coroutine)); // 4
    }


    // 1

    //IEnumerator MyCoroutine()
    //{
    //    Debug.Log("First");
    //    yield return null;
    //    Debug.Log("Second");

    //    // This coroutine only works one time
    //}


    // 2

    //IEnumerator MyCoroutine(float time)
    //{
    //    Debug.Log("First");
    //    yield return new WaitForSeconds(time);

    //    //The code below is executed after given time
    //    Debug.Log("Second");
    //}


    // 3

    IEnumerator MyCoroutine(float time)
    {
        while (true)
        {
            Debug.Log("Processing...");
            yield return new WaitForSeconds(time);
            
            //This code runs forever
        }

    }


    // 4

    IEnumerator SecondCoroutine(IEnumerator coroutine)
    {
        yield return new WaitForSeconds(5f);
        StopCoroutine(coroutine);
        Debug.Log("Coroutine is stopped after 5 seconds.");

        //This coroutine stops the given coroutine after 5 seconds.

        //StopAllCoroutines(); // Stops all coroutines
    }


}

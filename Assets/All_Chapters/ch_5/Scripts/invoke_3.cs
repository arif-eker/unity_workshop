using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class invoke_3 : MonoBehaviour
{

    private void Start()
    {
        Invoke("Speak", 2f);
        InvokeRepeating("Walk", 3f, .1f);
        StartCoroutine(CancelInvokeController("Walk"));
    }

    void Speak()
    {
        Debug.Log("Hello, my name is R2D2");
    }

    void Walk()
    {
        Debug.Log("Walking");
    }


    IEnumerator CancelInvokeController(string invokeName)
    {
        while (true)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                CancelInvoke(invokeName);
                Debug.Log("Invoke cancelled.");
                break;
            }

            //yield return null;
            yield return new WaitForSeconds(.02f);
            //Both can be used
        }
    }


}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class get_component_4 : MonoBehaviour
{


    BoxCollider boxCol;
    BoxCollider[] boxCols;

    void Start()
    {

        // 1
        // bad use
        //GetComponent<BoxCollider>().enabled = false;
        //GetComponent<BoxCollider>().isTrigger = false;

        // good use
        //boxCol = GetComponent<BoxCollider>();
        //boxCol.enabled = false;
        //boxCol.isTrigger = false;


        // 2
        boxCols = GetComponents<BoxCollider>();
        for (int i = 0; i < boxCols.Length; i++)
        {
            if (i > 0)
            {
                boxCols[i].size = new Vector3(1f, 2f, 3f);
            }
            else
                boxCols[i].enabled = false;
        }

    }



}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class prefab_obj_6 : MonoBehaviour
{

    void Start()
    {
        Destroy(gameObject, 2.5f);
    }

    private void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * 10f);
    }
}

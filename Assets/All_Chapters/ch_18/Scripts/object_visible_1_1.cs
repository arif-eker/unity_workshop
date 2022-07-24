using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class object_visible_1_1 : MonoBehaviour
{

    private void OnBecameInvisible()
    {
        gameObject.SetActive(false);
        Destroy(this);
    }
}

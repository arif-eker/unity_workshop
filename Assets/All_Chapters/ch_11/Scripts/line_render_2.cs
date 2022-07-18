using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class line_render_2 : MonoBehaviour
{

    LineRenderer line_render;

    void Start()
    {
        line_render = gameObject.AddComponent<LineRenderer>();
        
        line_render.material = new Material(Shader.Find("Sprites/Default"));
        line_render.useWorldSpace = false;

        line_render.startColor = Color.blue;
        line_render.endColor = Color.red;

        line_render.startWidth = .1f;
        line_render.endWidth = .01f;

        line_render.numCapVertices = 15;
    }


    void Update()
    {

        line_render.SetPosition(0, transform.forward);
        line_render.SetPosition(1, transform.forward * 10f);

    }
}

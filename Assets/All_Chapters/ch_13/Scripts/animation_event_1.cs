using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class animation_event_1 : MonoBehaviour
{

    Animator animator;

    private void Start()
    {
        animator = GetComponent<Animator>();
    }
    public void SayHello()
    {
        print("Hello from Cube animation :D");
    }


    private void Update()
    {


        if (Input.GetKeyDown("space"))
        {
            animator.SetTrigger("to_jump");
        }

        animator.SetBool("to_move", Input.GetKey("w"));

        print("Forward value : " + animator.GetFloat("Forward"));

        //float h = Input.GetAxis("Horizontal");
        //float v = Input.GetAxis("Vertical");
        //bool fire = Input.GetButton("Fire1");

        //animator.SetFloat("Forward", v);
        //animator.SetFloat("Strafe", h);
        //animator.SetBool("Fire", fire);


    }

}

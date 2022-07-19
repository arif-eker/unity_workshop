using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class canvas_2 : MonoBehaviour
{
    Image fish_img;

    void Start()
    {
        fish_img = GameObject.Find("fish").GetComponent<Image>();


        /*
         * fish_img.fillMethod:
         * 
         Horizontal (0)	 :  The Image will be filled Horizontally.
         Vertical	(1) :  The Image will be filled Vertically.
         Radial90	(2) :  The Image will be filled Radially with the radial center in one of the corners.
         Radial180	(3) :  The Image will be filled Radially with the radial center in one of the edges.
         Radial360	(4) :  The Image will be filled Radially with the radial center at the center.
        */

        fish_img.fillMethod = 0;

    }


    void Update()
    {

        if (fish_img.fillAmount > .5f)
        {
            fish_img.fillAmount -= .1f * Time.deltaTime;
        }

    }


    public void MyButtonClick()
    {
        print("Button Click");
    }

    public void SayYourNumber(float number)
    {
        print("Your number is : " + number);
    }


    public void SexChange(bool status)
    {
        if (status)
        {
            print("Sex: Male");
        }
        else
        {
            print("Sex: Female");
        }
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class canvas_3 : MonoBehaviour
{

    public Slider slider;
    void Start()
    {
        slider.minValue = 0;
        slider.maxValue = 200;
        slider.wholeNumbers = true;
    }


    void Update()
    {
        
    }


    //public void ShowSliderValue()
    //{
    //    print(slider.value);
    //}

    public void ShowSliderValue(float val)
    {
        print(val);
    }
}

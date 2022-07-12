using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class variables_2 : MonoBehaviour
{

    public string employeeName;
    public int age;
    public float salary;
    private string companyName;


    void Start()
    {
        companyName = "Unity Tech.";

        Debug.Log("employeeName : " + employeeName);
        Debug.Log("age : " + age);
        Debug.Log("salary ($) : " + salary);
        Debug.Log("companyName : " + companyName);

        if ( salary >3500f)
        {
            Debug.Log("Tax rate : %25");
        }
        else
        {
            Debug.Log("Tax rate : %15");
        }
    }



}

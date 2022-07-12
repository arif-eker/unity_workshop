using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class array_list_3 : MonoBehaviour
{


    public string[] employees; // array

    List<int> employeeAge = new List<int>(); // list


    void Start()
    {

        // array

        Debug.Log(employees);
        //for (int i = 0; i < employees.Length; i++)
        //{
        //    Debug.Log("Employee " + (i + 1) + " name is : " + employees[i]);
        //}

        //foreach (var employee in employees)
        //{
        //    Debug.Log("Emploee: " + employee);
        //}


        employeeAge.Add(23);
        employeeAge.Add(27);
        employeeAge.Add(33);

        for (int i = 0; i < employees.Length; i++)
        {
            Debug.Log("Employee " + (i + 1) + " name is : " + employees[i] + "and age " + employeeAge[i]);
        }


    }



}

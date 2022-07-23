using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.UI;

public class playerprefs_2 : MonoBehaviour
{

    public InputField playerName;
    public InputField playerAge;
    public InputField playerCity;

    

    void Start()
    {

        //Debug.Log("PlayerName  " + PlayerPrefs.GetString("PlayerName"));
        //Debug.Log("PlayerAge  " + PlayerPrefs.GetInt("PlayerAge"));
        //Debug.Log("PlayerCity  " + PlayerPrefs.GetInt("PlayerCity"));

        //PlayerPrefs.DeleteKey("PlayerName");
        //PlayerPrefs.DeleteAll();
        
    }

    public void SaveData()
    {
        PlayerPrefs.SetString("PlayerName", playerName.text);
        PlayerPrefs.SetInt("PlayerAge", Int32.Parse(playerAge.text));
        PlayerPrefs.SetString("PlayerCity", playerCity.text);
        //PlayerPrefs.Save();

        playerName.text = "";
        playerAge.text = "";
        playerCity.text = "";

    }

    public void ShowData()
    {
        playerName.text = PlayerPrefs.GetString("PlayerName");
        playerAge.text = PlayerPrefs.GetInt("PlayerAge").ToString();
        playerCity.text = PlayerPrefs.GetString("PlayerCity");
        PlayerPrefs.DeleteAll();
    }

}

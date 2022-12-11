using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using  SshConnect;
using UnityEngine.UI;
public class Menu : MonoBehaviour
{

    public InputField hostname;
    public InputField username;

    public void clickButton()
    {
        SshConnect.Ssh new_connection = new SshConnect.Ssh(hostname.text, username.text);
        new_connection.Create_password_connection("yourpassword");

        //PlayerPrefs.SetString("hostname", hostname.text);
        //Debug.Log("The hostname is" + PlayerPrefs.GetString("name"));
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using  SshConnect;
public class Menu : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        var ssh_instance = new SshConnect.Ssh("localhost", "priscila");
        Debug.Log("It is working!");
        ssh_instance.hello();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

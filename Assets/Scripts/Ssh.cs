using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Renci.SshNet;
using System.IO;


public class Ssh
{
    private string Host;
    private string UserName;

    
   void Create_password_connection(string Host, string UserName, string Password)
    {
        ConnectionInfo ConnNfo = new ConnectionInfo(Host, 22, UserName,
new AuthenticationMethod[]{
       new PasswordAuthenticationMethod(UserName,Password),

});
    }


// Create an SSH object to send various kinds of data!
}

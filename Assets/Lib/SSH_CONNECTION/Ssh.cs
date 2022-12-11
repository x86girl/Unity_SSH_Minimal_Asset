using System.Collections;
using System.IO;
using System.Collections.Generic;
using UnityEngine;
using System.Text;
using Renci.SshNet;
namespace SshConnect
{
    public class Ssh
    {

        string Host;
        string UserName;

    public Ssh(string Host_, string UserName_)
        {
            this.Host = Host_;
            this.UserName = UserName_;
        }

        public void Create_password_connection(string Password)
        {
            ConnectionInfo ConnNfo = new ConnectionInfo(this.Host, 22, this.UserName,
    new AuthenticationMethod[]{
       new PasswordAuthenticationMethod(this.UserName,Password),

    });
        }

        public void Create_SFTP_connection(string Password, string folder, string Path, string FileName)
        {
            ConnectionInfo ConnNfo = new ConnectionInfo(this.Host, 22, this.UserName,
            new AuthenticationMethod[]{
            new PasswordAuthenticationMethod(this.UserName ,Password),

     }
 );
            using (var sftp = new SftpClient(ConnNfo))
            {

                sftp.Connect();
                sftp.ChangeDirectory(Path);
                using (var uplfileStream = File.OpenRead(FileName))
                {
                    sftp.UploadFile(uplfileStream, FileName);
                }
                sftp.Disconnect();
            }

        }


        // Create an SSH object to send various kinds of data!
    }
}

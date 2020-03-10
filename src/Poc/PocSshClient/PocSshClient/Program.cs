using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Renci.SshNet;
using Renci.SshNet.Common;
using Renci.SshNet.Sftp;

namespace PocSshClient
{
    class Program
    {
        static void Main(string[] args)
        {
            TestSimpleCommand();

            Console.ReadKey();
        }

        static void TestSimpleCommand()
        {
            SshClient sshclient = new SshClient("server", "user", "password");
            sshclient.Connect();
            SshCommand sc = sshclient.CreateCommand("cd ..");
            sc.Execute();
            sc = sshclient.CreateCommand("ls -al /data/current/config");
            sc.Execute();
            string answer = sc.Result;
            Console.WriteLine(answer);
            sc = sshclient.CreateCommand("cat /data/apex/current/config/Environment.cfg");
            sc.Execute();
            answer = sc.Result;
            Console.WriteLine(answer);
        }

    }
}

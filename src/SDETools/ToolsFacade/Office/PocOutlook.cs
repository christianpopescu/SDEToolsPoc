using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Outlook = Microsoft.Office.Interop.Outlook;
using System.Runtime.InteropServices;

namespace ToolsFacade
{
    class PocOutlook
    {
        void BindToRunningProcessesOutlook()
        {
            // Get the current process.
            Process currentProcess = Process.GetCurrentProcess();
 
            // Get all processes running on the local computer.
            Process[] localAll = Process.GetProcessesByName("OUTLOOK");
 
            foreach (var pr in localAll)
            {
                Console.WriteLine(pr.Id + " - " + pr.ProcessName + " " + pr.HandleCount);
                //Console.WriteLine(pr.Id + " - " + pr.ProcessName );
                try
                {
                    Console.WriteLine("   ", pr.MainModule.ModuleName);
                }
                catch (Exception ex)
                {; }
            }
            Outlook.Application application;
            if (localAll.Length > 0) application = Marshal.GetActiveObject("Outlook.Application") as Outlook.Application;
            else application = new Outlook.Application();
 
 
            Console.WriteLine(application.Explorers.Count);
 
            Outlook.Folder root = application.Session.DefaultStore.GetRootFolder() as Outlook.Folder;
 
            Outlook.Folders childFolders = root.Folders;
 
            Console.WriteLine(childFolders.Count);
 
            foreach (Outlook.Folder fld in childFolders)
            {
                Console.WriteLine(" " + fld.Name);
                if (fld.Name == "Inbox")
                {
                    foreach(Outlook.Folder finbox in fld.Folders)
                        Console.WriteLine("      " + finbox.Name);
                    Outlook.Items it = fld.Items.Restrict("[MessageClass]='IPM.Note'");
                    for (int i = 1; i <= it.Count; i++)
                        Console.WriteLine(it[i].Subject); 
                }
 
            }
 
            Console.ReadKey();
        }

    }
}

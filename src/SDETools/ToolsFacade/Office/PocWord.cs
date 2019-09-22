using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Word = Microsoft.Office.Interop.Word;

namespace ToolsFacade.Office
{
    class PocWord
    {
        void BindToRunningProcesses()
        {
            // Get the current process.
            Process currentProcess = Process.GetCurrentProcess();
 
            // Get all processes running on the local computer.
            Process[] localAll = Process.GetProcessesByName("WINWORD");
 
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
            Word.Application application;
            if (localAll.Length >0)    application = Marshal.GetActiveObject("Word.Application") as Word.Application;
            else  application = new Word.Application();
 
            
            Console.WriteLine(application.Documents.Count);
            Console.WriteLine(application.Version);
            //for (int i=0; i< application.Documents.Count; i++)
            //    Console.WriteLine(application.Documents[i].);
 
            foreach (Word.Document d in application.Documents)
                Console.WriteLine(d.Name);
 
 
            Console.ReadKey();
        }

    }
}

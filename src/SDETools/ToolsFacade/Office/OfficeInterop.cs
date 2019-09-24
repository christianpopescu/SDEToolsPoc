using System;
using System.Diagnostics;

namespace ToolsFacade.Office
{
    public abstract class OfficeInterop
    {
        protected Type AppType;
        protected string TypeName;
        protected string ProcessName;

        public static T BindToRunningProcessOrNew<T>() where T : OfficeInterop
        {
            T t;
            // Get the current process.
            Process currentProcess = Process.GetCurrentProcess();
 
            // Get all processes running on the local computer.
            Process[] localAll = Process.GetProcessesByName("EXCEL");
            Excel.Application application;
            if (localAll.Length > 0) application = Marshal.GetActiveObject("Excel.Application") as Excel.Application;
            else application = new Excel.Application();

            return
        }

        public static void ReleaseObject(object obj)
        {
            try
            {
                System.Runtime.InteropServices.Marshal.ReleaseComObject(obj);
                obj = null;
            }
            catch (Exception ex)
            {
                // todo : log exception
                obj = null;
            }
            finally
            {
                GC.Collect();
            }
        }

    }
}

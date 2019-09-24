using System;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace ToolsFacade.Office
{
    public abstract class OfficeInterop<T>
    {
        protected T Application;
        //protected Type AppType;
        protected string TypeName;
        protected string ProcessName;

        // todo: see if possible to mutualize the bind or new method
/*        protected T BindToRunningProcessOrNew<T>() where T : class,new()
        {
            // Get the current process.
            Process currentProcess = Process.GetCurrentProcess();
 
            // Get all processes running on the local computer.
            Process[] localAll = Process.GetProcessesByName(ProcessName);
           T application;
            if (localAll.Length > 0) application = Marshal.GetActiveObject(TypeName) as T;
            else application = new T();

            return application;
        }
*/
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

using System;

namespace ToolsFacade.Office
{
    public class OfficeInterop
    {
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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PocExcel.ExcelTools
{
    public class OfficeInterops
    {
        protected static void ReleaseObject(object obj)
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

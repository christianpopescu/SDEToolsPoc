using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToolsFacade.Office;
using Microsoft.Office.Interop.Excel;

using Excel = Microsoft.Office.Interop.Excel;


namespace SDEConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            MsExcel ms = MsExcel.GetInstance();
        }
    }
}

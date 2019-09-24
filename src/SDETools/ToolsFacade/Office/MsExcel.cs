using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excel = Microsoft.Office.Interop.Excel;

namespace ToolsFacade.Office
{
    public class MsExcel : OfficeInterop
    {
        private MsExcel _instance;
        
        private Excel.Application _excelApplication;

        static MsExcel()
        {
            AppType = typeof(Excel.Application);
            TypeName = "Excel.Application";
            ProcessName = "EXCEL";
        }

        private MsExcel()
        {
            
        }

        public MsExcel GetInstance()
        {
            return _instance ?? (_instance = new MsExcel());
        }
    }
}

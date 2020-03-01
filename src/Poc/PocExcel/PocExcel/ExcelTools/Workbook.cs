using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excel = Microsoft.Office.Interop.Excel;

namespace PocExcel.ExcelTools
{
    public class Workbook
    {
        protected Excel.Workbook _workbook;
        Workbook(Excel.Workbook aWorkbook)
        {
            _workbook = aWorkbook;
        }

        public string FullName { get { return (_workbook?.FullName?? ""); } }
    }
}

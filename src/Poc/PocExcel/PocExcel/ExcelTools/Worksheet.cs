using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excel = Microsoft.Office.Interop.Excel;

namespace PocExcel.ExcelTools
{
    public class Worksheet
    {
        protected Excel.Worksheet _worksheet;

        public Worksheet(Excel.Worksheet aWorksheet)
        {
            _worksheet = aWorksheet;
        }

        public string Name { get { return (_worksheet?.Name ?? ""); } }

        public int RowsCount { get { return _worksheet.Cells.Rows.Count; } }

        public int ColumnsCount { get { return _worksheet.Cells.Columns.Count; } }

        public string GetCellValue(int row, int column)
        {
            return (_worksheet.Cells[row, column]?.Value ?? "").ToString();
        }
    }
}

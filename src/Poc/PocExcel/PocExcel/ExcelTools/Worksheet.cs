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

        public void SetCellValue(int row, int column, string val)
        {
            _worksheet.Cells[row, column].Value = val ;
        }

        public  List<List<string>> GetTable(int top, int left, int bottom, int right)
        {
            var result = new List<List<string>>();
            for (int r = top; r<=bottom; r++) 
            {
                var row = new List<string>();
                for (int c = left; c <= right; c++) row.Add((_worksheet.Cells[r, c]?.Value ?? "").ToString());
                result.Add(row);
            }
            return result;
        }

        public List<List<string>> GetTableType(int top, int left, int bottom, int right)
        {
            var result = new List<List<string>>();
            for (int r = top; r <= bottom; r++)
            {
                var row = new List<string>();
                for (int c = left; c <= right; c++) row.Add((_worksheet.Cells[r, c].Value?.GetType().ToString() ?? ""));
                result.Add(row);
            }
            return result;
        }

        public List<List<dynamic>> GetTableDynamic(int top, int left, int bottom, int right)
        {
            var result = new List<List<dynamic>>();
            for (int r = top; r <= bottom; r++)
            {
                var row = new List<dynamic>();
                for (int c = left; c <= right; c++) row.Add((_worksheet.Cells[r, c].Value));
                result.Add(row);
            }
            return result;
        }
    }
}

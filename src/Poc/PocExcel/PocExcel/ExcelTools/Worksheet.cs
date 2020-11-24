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

        public void SetCellFontStyle(int row, int column, string pFontStyle, int startChar = 0, int length = 0)
        {
            if (startChar > 0 && length > 0)
            {
                _worksheet.Cells[row, column].Characters(Start: startChar, Length: length).Font.FontStyle = pFontStyle;
            }
            else
                _worksheet.Cells[row, column].Font.FontStyle = pFontStyle;
        }

        public void SetCellColor(int row, int column, System.Drawing.Color pColor , int startChar = 0, int length = 0)
        {
            if (startChar > 0 && length > 0)
            {
                _worksheet.Cells[row, column].Characters(Start: startChar, Length: length).Font.Color 
                    = System.Drawing.ColorTranslator.ToOle(pColor);
            }
            else
                _worksheet.Cells[row, column].Font.Color
                    = System.Drawing.ColorTranslator.ToOle(pColor);
        }


        public List<List<string>> GetTable(int top, int left, int bottom, int right)
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

        public void SetTable(List<List<String>> pTable, int top, int left)
        {
            int currentRow = 0;
            foreach (var row in pTable)
            {
                int currentColumn = 0;
                foreach (var cell in row)
                {
                    _worksheet.Cells[currentRow+top, currentColumn + left].value = cell;
                    currentColumn++;
                }
                currentRow++;
            }    
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

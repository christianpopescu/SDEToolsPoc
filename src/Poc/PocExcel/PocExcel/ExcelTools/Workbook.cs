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
        public Workbook(Excel.Workbook aWorkbook)
        {
            _workbook = aWorkbook;
        }
        
        public string FullName { get { return (_workbook?.FullName?? ""); } }

        public string Name { get { return (_workbook?.Name ?? ""); } }

        public void Close()
        {
            _workbook.Close(false);
        }

        public void Save()
        {
            _workbook.Save();
        }

        public List<Worksheet> WorksheetList
        {
            get
            {
                var result = new List<Worksheet> ();
                foreach (var ws in _workbook.Worksheets)
                {
                    result.Add(new Worksheet((Excel.Worksheet)ws));
                }
                return result;
            }
        }

        public Boolean WorksheetExists(String pName)
        {
            List<Worksheet> lws = WorksheetList;
            foreach (var ws in lws)
                if (string.Equals(pName, ws.Name)) 
                    return true;
            return false;
        }

        public void AddWorksheet(String pWorksheetName, Boolean pOverride = false)
        {
            if (WorksheetExists(pWorksheetName))
                if (pOverride)
                    ((Excel.Worksheet)_workbook.Worksheets[pWorksheetName]).Delete();
                else
                    return;
            Excel.Worksheet ews = _workbook.Worksheets.Add();
            ews.Name = pWorksheetName;
        }
    }
}

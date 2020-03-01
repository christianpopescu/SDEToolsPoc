using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Excel = Microsoft.Office.Interop.Excel;

namespace PocExcel.ExcelTools
{

    public class MsExcel : OfficeInterops
    {
        private static MsExcel _instance;

        private Excel.Application _excelApplication;

        private static readonly string _typeName = "Excel.Application";
        private static readonly string _processName = "EXCEL";
        private MsExcel()
        {
        }

        public static MsExcel GetInstance()
        {
            if (_instance != null) return _instance;
            _instance = new MsExcel();
            try
            {
                _instance._excelApplication = BindToRunningProcessOrNew();
            }
            catch (Exception ex)
            {
                // todo log exception
                _instance = null;
            }
            return _instance;
        }

        protected static Excel.Application BindToRunningProcessOrNew()
        {
            // Get the current process.
            Process currentProcess = Process.GetCurrentProcess();

            // Get all processes running on the local computer.
            Process[] localAll = Process.GetProcessesByName(_processName);
            Excel.Application application;
            if (localAll.Length > 0) application = Marshal.GetActiveObject(_typeName) as Excel.Application;
            else application = new Excel.Application();

            return application;
        }

        public void Open(String Name)
        {
            MsExcel.GetInstance()._excelApplication.Workbooks.Open(Name);
        }
    }
}

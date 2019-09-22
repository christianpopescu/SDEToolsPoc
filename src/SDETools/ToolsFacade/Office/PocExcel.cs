using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Excel = Microsoft.Office.Interop.Excel;

namespace ToolsFacade.ExcelFacade
{
    class PocExcel
    {
        static readonly Excel.DocEvents_DeactivateEventHandler dh =() => Console.WriteLine("Desactivate");
        static void PocOpenDelimitedInExcel()
        {
            Excel.Application xlApp;
            //Excel.Workbook xlWorkBook;
            //Excel.Worksheet xlWorkSheet;
            Excel.Range range;
            xlApp = new Excel.Application();
            Excel.Workbooks xlWorkBooks = xlApp.Workbooks;
            xlWorkBooks.OpenText(@"E:\ccp_vhdd\SI_20170426.txt",null,Excel.XlTextParsingType.xlDelimited);

            //xlWorkBook.Close(true, null, null);
            xlApp.Quit();

            //releaseObject(xlWorkSheet);
            //releaseObject(xlWorkBook);
            releaseObject(xlApp);



        }

        public static void TestDelimitedEvolutated()
        {
            Excel.Application xlApp;
            //Excel.Workbook xlWorkBook;
            //Excel.Worksheet xlWorkSheet;
            Excel.Range range;
            xlApp = new Excel.Application();
            Excel.Workbooks xlWorkBooks = xlApp.Workbooks;
// original call            xlWorkBooks.OpenText(@"E:\ccp_vhdd\01-Dev\QC\QC2078\04-Recette\_recette_amf\02-0427-01\Prod\SI_20170426.txt",null,Excel.XlTextParsingType.xlDelimited);
            xlWorkBooks.OpenText(@"E:\ccp_vhdd\01-Dev\QC\QC2078\04-Recette\_recette_amf\02-0427-01\Prod\SI_20170426.txt",1,1, Excel.XlTextParsingType.xlDelimited, Excel.XlTextQualifier.xlTextQualifierNone,false,false,true);


            Excel.Workbook xlWorkBook = xlWorkBooks[1]; 
            int cnt = xlWorkBooks.Count;
            Excel.Worksheet xlWorkSheet = xlWorkBook.Sheets[1];


            Console.WriteLine(cnt);
            Console.WriteLine(xlWorkBook.Name);
            Console.WriteLine(xlWorkBook.Worksheets.Count);

            xlWorkSheet.Columns.ClearFormats();
            xlWorkSheet.Rows.ClearFormats();

            int col = xlWorkSheet.UsedRange.Columns.Count;
            int row = xlWorkSheet.UsedRange.Rows.Count;

            Console.WriteLine(xlWorkSheet.UsedRange.Columns.Count);
            Console.WriteLine(xlWorkSheet.UsedRange.Rows.Count);

            Excel.Range xlRange = xlWorkSheet.UsedRange;
            for (int i = 1; i <= row; i++)
            {
                for (int j=1; j<=col; j++)
                {
                    Console.Write(xlRange[i, j].Value);
                    Console.Write("  ");
                }
                Console.WriteLine();
            }


            //xlWorkBook.Close(true, null, null);
            xlApp.Quit();

            //releaseObject(xlWorkSheet);

            // releaseObject(xlWorkBook);
            releaseObject(xlWorkBooks);
            releaseObject(xlApp);



        }

        static void BindToRunningProcessesExcel()
        {
            // Get the current process.
            Process currentProcess = Process.GetCurrentProcess();
 
            // Get all processes running on the local computer.
            Process[] localAll = Process.GetProcessesByName("EXCEL");
            Excel.Application application;
            if (localAll.Length > 0) application = Marshal.GetActiveObject("Excel.Application") as Excel.Application;
            else application = new Excel.Application();
 
            if (application.Workbooks.Count == 0) Console.WriteLine("No workbook opened!");
            else
            {
                Excel.Workbook workBookPmo = null;
                foreach (Excel.Workbook w in application.Workbooks)
                {
                    Console.WriteLine(w.FullName + "  |  " + w.Name);
                    if (w.Name == "PMO_Main.xlsx")
                    {
                        Console.WriteLine(w.Worksheets.Count);
                        workBookPmo = w;
                    }
                }
                if (workBookPmo != null)
                {
                    Console.WriteLine(((Excel.Worksheet)workBookPmo.ActiveSheet).Name);
                }
                ((Excel.Worksheet)workBookPmo.ActiveSheet).Deactivate += dh;
 
            }
            Console.ReadKey();
        }


        private static void releaseObject(object obj)
        {
            try
            {
                System.Runtime.InteropServices.Marshal.ReleaseComObject(obj);
                obj = null;
            }
            catch (Exception ex)
            {
                obj = null;
                //MessageBox.Show("Unable to release the Object " + ex.ToString());
            }
            finally
            {
                GC.Collect();
            }
        }


    }
}

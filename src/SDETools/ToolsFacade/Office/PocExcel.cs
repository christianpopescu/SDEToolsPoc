using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excel = Microsoft.Office.Interop.Excel;

namespace ToolsFacade.ExcelFacade
{
    class PocExcel
    {
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

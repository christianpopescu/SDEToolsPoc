using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PocExcel.ExcelTools;

namespace PocExcel
{
    class Program
    {
        static void Main(string[] args)
        {
            MsExcel.GetInstance().Open(@"E:\Temp\ToDelete\SecondWorkbook.xlsx");
            List<Workbook> lw = MsExcel.GetInstance().GetOpenWorkbooks();
            foreach(var w in lw)
            {
                Console.WriteLine(w.Name + "  " + w.FullName);
                var l = w.WorksheetList;
                foreach(var ws in l)
                {
                    Console.WriteLine("  " + ws.Name);
                    Console.WriteLine("   Rows = " + ws.RowsCount);
                    Console.WriteLine("   Columns = " + ws.RowsCount);

                    for (int r = 1; r < 5; r++)
                        for (int c = 1; c < 4; c++)
                            Console.WriteLine("    " + ws.GetCellValue(r, c));
                    ws.SetCellValue(10, 10, "Test");
                    //List<List<string>> lls = ws.GetTable(1, 1, 4, 2);
                    List<List<string>> lls = ws.GetTableType(1, 1, 5, 2);
                    foreach (var row in lls)
                    {
                        foreach (var col in row)
                            Console.Write(col + " | ");
                        Console.WriteLine();
                    }
                }
            }
            Console.ReadKey();
        }
    }
}

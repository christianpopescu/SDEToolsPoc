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
                    Console.WriteLine("    " + ws.GetCellValue(1, 1));
                }
            }
            Console.ReadKey();
        }
    }
}

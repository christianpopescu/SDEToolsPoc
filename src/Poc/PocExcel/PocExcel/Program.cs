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
            List<Workbook> lw = MsExcel.GetInstance().GetOpenWorkbooks();
            foreach(var v in lw)
            {
                Console.WriteLine(v.FullName);
            }
            Console.ReadKey();
        }
    }
}

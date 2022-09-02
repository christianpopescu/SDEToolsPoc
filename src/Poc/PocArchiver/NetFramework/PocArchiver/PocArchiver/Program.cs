using System;
using System.Collections.Generic;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PocArchiver
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pathSource = @"D:\ccp_vhdd_main\Portfolios\CareerManagement";
            string pathDest = @"D:\temp\CareerManagement.zip";
            ZipFile.CreateFromDirectory(pathSource, pathDest);
        }
    }
}

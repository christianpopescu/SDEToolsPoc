using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using fr.vadc.OSFacade.Interfaces;

namespace fr.vadc.OSFacade.WindowsImplementation
{
    public class WinDirectory : IOSDirectory
    {
        public static IEnumerable<string> EnumerateDirectories(string pPath)
        {
            return Directory.EnumerateDirectories(pPath);
        }

        public static IEnumerable<string> EnumerateFiles(string pPath)
        {
            return Directory.EnumerateDirectories(pPath);
        }
    }
}

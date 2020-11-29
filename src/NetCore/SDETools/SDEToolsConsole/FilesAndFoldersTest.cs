using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDEToolsConsole
{
    public class FilesAndFoldersTest
    {
        public static void TestDirectoryMethods()
        {
            String pathToDirctory = @"E:\Temp\TempToDelete";
            String pathToFile = @"E:\Temp\TempToDelete\input.txt";
            String pathToNothing = @"E:\Temp\TempToDelete\inputxyz.txt";

            Console.WriteLine(Directory.Exists(pathToDirctory));
            Console.WriteLine(Directory.Exists(pathToFile));
            Console.WriteLine(Directory.Exists(pathToNothing));

        }
        public static void TestEnumeration()
        {
            String pathToDirctory = @"E:\Temp\TempToDelete";
            String pathToFile = @"E:\Temp\TempToDelete\input.txt";
            String pathToNothing = @"E:\Temp\TempToDelete\inputxyz.txt";

            Console.WriteLine("Enumerate Directories");
            foreach (var dir in Directory.EnumerateDirectories(pathToDirctory))
                Console.WriteLine(dir + " | " + Path.GetDirectoryName(dir) + " | " + Path.GetFullPath(dir));
            Console.WriteLine("Enumerate Files");
            foreach (var file in Directory.EnumerateFiles(pathToDirctory))
                Console.WriteLine(file +" | " + Path.GetFileName(file) + " | " + Path.GetFullPath(file));

        }
    }
}

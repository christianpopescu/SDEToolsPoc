using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using fr.vadc.FilesAndFoldersHelper;

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

        public static void TestRecursiveEnumeration()
        {
            FolderRecursiveEnumeration(@"E:\Temp\TempToDelete", 0);
        }

        private static void FolderRecursiveEnumeration(String path, int level)
        {
            String prefix = new string(' ', level * 2);
            foreach (var dir in Directory.EnumerateDirectories(path))
                Console.WriteLine($"{prefix}Directory: {dir} | {Path.GetFileName(dir)} | {Path.GetDirectoryName(dir)}");
            foreach (var file in Directory.EnumerateFiles(path))
                Console.WriteLine($"{prefix}File: {file} | {Path.GetFileName(file)} | {Path.GetDirectoryName(file)}");
            foreach (var dir in Directory.EnumerateDirectories(path))
                FolderRecursiveEnumeration(dir, level+1);

        }

        public static void UseFilesAndFoldersHelper_Enumerate()
        {
            FileAndFolderService ffs = new FileAndFolderService();
            List<IFileOrFolder> list = ffs.GetListOfFilesAndFolders(@"E:\Temp\TempToDelete");
            foreach (var fof in list)
                Console.WriteLine($" {Path.GetFileName(fof.FullName)}");
        }
    }
}

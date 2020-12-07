using System;
using System.Collections.Generic;
using System.IO;
using fr.vadc.FilesAndFoldersHelper;
using fafh = fr.vadc.FilesAndFoldersHelper;
using fr.vadc.AbstractDataHelper.Collections;

namespace SDEToolsConsole
{
    public static  class FilesAndFoldersTest
    {
        public static void TestDirectoryMethods(string pPathToDirctory, string pPathToFile, string pPathToNothing)
        {
            Console.WriteLine(Directory.Exists(pPathToDirctory));
            Console.WriteLine(Directory.Exists(pPathToFile));
            Console.WriteLine(Directory.Exists(pPathToNothing));

        }
        public static void TestEnumeration()
        {
            String pathToDirctory = @"E:\Temp\TempToDelete";

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
            List<IFileOrFolder> list = ffs.GetListOfFilesAndFolders(@"E:\Temp\TempToDelete",
                ElementSelection.file );
            foreach (var fof in list)
                Console.WriteLine($" {Path.GetFileName(fof.FullName)}");
        }

        public static void UseFilesAndFoldersHelper_GetMultipleFiles()
        {
            FileAndFolderService ffs = new FileAndFolderService();
            List<IFileOrFolder> list = ffs.GetListOfFilesAndFolders(@"F:\CCP_library",
                ElementSelection.file);

            list.Sort(fafh.File.CompareByName);

            int countduplicates = 0;

            for (int i = 1; i < list.Count; i++)
            {
                if (Path.GetFileName(list[i - 1].FullName) == Path.GetFileName(list[i].FullName))
                {
                    Console.WriteLine(list[i-1].FullName);
                    Console.WriteLine(list[i].FullName);
                    countduplicates++;
                }
            }

            Console.WriteLine(countduplicates);


        }


        public static void UseFilesAndFoldersHelper_GetMultipleFiles_action(string pRootFolder, string pOutputResult)
        {
            ListOfElements<string> loes =
                ListOfElements<string>.CreateListOfElements<string>((x) => x, (x) => x);
            FileAndFolderService ffs = new FileAndFolderService();
            List<IFileOrFolder> list = ffs.GetListOfFilesAndFolders(pRootFolder,
                ElementSelection.file);

            list.Sort(fafh.File.CompareByNameAndDirectory);

            int countDuplicates = 0;

            for (int i = 1; i < list.Count; i++)
            {
                if (Path.GetFileName(list[i - 1].FullName) == Path.GetFileName(list[i].FullName))
                {
                    loes.TheList.Add(list[i - 1].FullName);
                    loes.TheList.Add(list[i].FullName);
                    countDuplicates++;
                }
            }

            Console.WriteLine(countDuplicates);
            loes.WriteToFile(pOutputResult);

        }

    }
}

using System;

namespace SDEToolsConsole
{
    static class  Program
    {
        static void Main(string[] args)
        {
            if (args.Length > 0)
            {
                foreach (var arg in args)
                    Console.WriteLine(arg);
            }

            //FilesAndFoldersTest.TestDirectoryMethods(@"E:\Temp\TempToDelete", @"E:\Temp\TempToDelete\input.txt", @"E:\Temp\TempToDelete\inputxyz.txt");
            FilesAndFoldersTest.UseFilesAndFoldersHelper_GetMultipleFiles_action(@"F:\CCP_library", @"E:\Temp\ToDelete\duplicates_new.txt");
            Console.Write("Press any key!");
            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;


    class FilesAndFolders
    {
        /// <summary>
        ///  Test the enumeration of the files between 
        /// </summary>
        public static void TestListFiles()
        {
            foreach (var s in ListFilesBetweenTwoDateTimeRegexList(@"\\nas-01\CCP_library\Doc_IT\Microsoft\C#",
                new DateTime(2010, 04, 15, 12, 0, 0),
                new DateTime(2021, 04, 15, 13, 0, 0),
                new List<string>() {"pdf"}))
            {
                Console.WriteLine(Path.GetFileName(s));
                Console.WriteLine("  " + Path.GetDirectoryName(s));
            }
        }

        /// <summary>
        /// Test copy file with rename
        /// </summary>

        public static void TestCopyFiles()
        {
            foreach (var s in ListFilesBetweenTwoDateTimeRegexList(@"\\nas-01\CCP_library\Doc_IT\Microsoft\C#",
                new DateTime(2010, 04, 15, 12, 0, 0),
                new DateTime(2021, 04, 15, 13, 0, 0),
                new List<string>() { "C#" }))
            {
                CopyFile(s, @"E:\Temp\ToDelete\Destination", x=>x+".back") ;
            }
        }

        /// <summary>
        /// Enumerates the files for the given path between to point in time
        /// </summary>
        /// <param name="pPath"></param>
        /// <param name="pFrom"></param>
        /// <param name="pTo"></param>
        /// <returns></returns>
        public static IEnumerable<string> ListFilesBetweenTwoDateTime(string pPath, DateTime pFrom, DateTime pTo) => Directory.EnumerateFiles(pPath)
            .Where(x
                =>
            {
                var fi = new FileInfo(x);
                //Console.WriteLine(fi.Name + "    " + fi.LastWriteTime);
                return (fi.LastWriteTime >= pFrom &&
                        fi.LastWriteTime <= pTo);
            });



        /// <summary>
        /// Enumerates the files for the given path between to point in time
        /// </summary>
        /// <param name="pPath"></param>
        /// <param name="pFrom"></param>
        /// <param name="pTo"></param>
        /// <param name="pPatternList">The RegEx pattern for a file name to be selected</param>
        /// <returns>IEnumerable of files that fill the conditions</returns>


        public static IEnumerable<string> ListFilesBetweenTwoDateTimeRegexList(string pPath, DateTime pFrom, DateTime pTo,
            IEnumerable<string> pPatternList)
        {
            List<Regex> regexList = new List<Regex>();
            foreach (string s in pPatternList)
                regexList.Add(new Regex(s));
            return Directory.EnumerateFiles(pPath)
                .Where(x
                    =>
                {
                    var fi = new FileInfo(x);
                    string fileName = fi.Name;
                    bool isMatch = false;
                    if (regexList.Count > 0)
                    {
                        foreach (var rx in regexList)
                            if (rx.IsMatch(fileName))
                            {
                                isMatch = true;
                            }
                    }
                    else
                        isMatch = true;

                    return (isMatch && fi.LastWriteTime >= pFrom &&
                            fi.LastWriteTime <= pTo);
                });
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="pSourceFile"></param>
        /// <param name="pDestinationFolder"></param>
        /// <param name="pTransformName">FunctionThat Transform Source file name to destination filename
        ///  no source = destinqtion if no delegate passed as parameter</param>
        public static void CopyFile(string pSourceFile, string pDestinationFolder, 
            Func<string, string> pTransformName = null)
        {
            pTransformName ??= x => x;

            File.Copy(pSourceFile,
                Path.Combine(pDestinationFolder, pTransformName(Path.GetFileName(pSourceFile))));

        }
    }

using System;
using System.Collections.Generic;

namespace FileHelper
{
    /// <summary>
    /// Responsibility : Allow small changes (by line) in text file
    /// Scenarios : Changing Configuration files, Project Files, ....
    /// </summary>
    public class TextFileChanger
    {
        public String InputFile { get; set; }
        public String TmpFile { get; set; }
        public String BackupFilePrefix { get; set; }
        public String  BackupFile => BackupFilePrefix + DateTime.Now.ToString(@"yyyyMMdd_HHmmss");
        public List<string> FileContent = new List<string>();
    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fr.vadc.FilesAndFoldersHelper
{
    public class File : IFileOrFolder
    {
        public string FullName { get; private set; }

        public readonly List<IFileOrFolder> Content = new List<IFileOrFolder>(); 

        protected File(){}

        public static File ConstructFile(String pFullName)
        {
            return new File() {FullName = pFullName};
        }

        // TODO: common behavior move to common class for file and folder
        public static int CompareFileByName(IFileOrFolder first, IFileOrFolder second)
        {
            if (first == null && second == null) return 0; // equals
            if (first == null && second != null) return -1; // second greater
            if (first != null && second == null) return 1;  // first is greater
            return Path.GetFileName(first.FullName).CompareTo(Path.GetFileName(second.FullName));
        }
    }
}

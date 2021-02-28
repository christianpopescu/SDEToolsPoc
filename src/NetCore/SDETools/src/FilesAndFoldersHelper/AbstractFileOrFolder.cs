using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fr.vadc.FilesAndFoldersHelper
{
    public class AbstractFileOrFolder : IFileOrFolder
    {
        public string FullName { get; protected set; }
        public string Name => Path.GetFileName(FullName);
        public string DirectoryName => Path.GetDirectoryName(FullName);

        public static int CompareByName(IFileOrFolder first, IFileOrFolder second)
        {
            if (first == null && second == null) return 0; // equals
            if (first == null) return -1; // second greater
            if (second == null) return 1;  // first is greater
            return String.Compare(first.Name, second.Name, StringComparison.Ordinal);
        }
        public static int CompareByNameAndDirectory(IFileOrFolder first, IFileOrFolder second)
        {
            if (first == null && second == null) return 0; // equals
            if (first == null) return -1; // second greater
            if (second == null) return 1;  // first is greater
            if (first.Name == second.Name)
                return String.Compare(first.DirectoryName, second.DirectoryName, StringComparison.Ordinal);
            else
                return String.Compare(first.Name, second.Name, StringComparison.Ordinal);
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fr.vadc.FilesAndFoldersHelper
{
    public class Folder<T> : IFileOrFolder<T>
    {
        public string Name { get; set; }
        public string FullName { get; set; }
        public T Data { get; set; }

        public List<IFileOrFolder<T>> Content = new List<IFileOrFolder<T>>();

        public Folder(String pName, String pFullName)
        {
            Name = pName;
            FullName = pFullName;
        }

    }
}

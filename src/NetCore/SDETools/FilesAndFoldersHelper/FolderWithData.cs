using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fr.vadc.FilesAndFoldersHelper
{
    public class FolderWithData<T> : IFileOrFolderWithData<T>
    {
        public string Name { get; set; }
        public string FullName { get; set; }
        public T Data { get; set; }

        public List<IFileOrFolderWithData<T>> Content = new List<IFileOrFolderWithData<T>>();

        public FolderWithData(String pName, String pFullName)
        {
            Name = pName;
            FullName = pFullName;
        }

    }
}

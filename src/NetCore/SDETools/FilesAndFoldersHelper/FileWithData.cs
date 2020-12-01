using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fr.vadc.FilesAndFoldersHelper
{
    public class FileWithData<T> : IFileOrFolderWithData<T>
    {
        public string Name { get; set; }
        public string FullName { get; set; }
        public T Data { get; set; }
    }
}

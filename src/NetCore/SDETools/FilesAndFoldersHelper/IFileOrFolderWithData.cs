using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Interface use to implement Composite Pattern
/// </summary>

namespace fr.vadc.FilesAndFoldersHelper
{
    public interface IFileOrFolderWithData<T> : IFileOrFolder
    {
 
        public T Data { get; set; }
    }
}

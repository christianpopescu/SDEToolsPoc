using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fr.vadc.FilesAndFoldersHelper
{
    /// <summary>
    /// Interface use to implement Composite Pattern
    /// </summary>
    /// 

    public class AbstractFileOrFolderWithData<T> : AbstractFileOrFolder
    {
        public T Data { get; set; }
    }
}

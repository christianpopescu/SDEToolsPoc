using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fr.vadc.FilesAndFoldersHelper
{
    /// <summary>
    /// Keeps informations about a directory keeps all files and folders 
    /// </summary>
    public class Directory<T>
    {
        public FolderWithData<T> Root { get; set; }
    }
}

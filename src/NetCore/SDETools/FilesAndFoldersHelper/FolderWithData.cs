using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fr.vadc.FilesAndFoldersHelper
{
    public class FolderWithData<T> : AbstractFileOrFolderWithData<T>
    {
        public List<AbstractFileOrFolderWithData<T>> Content = new List<AbstractFileOrFolderWithData<T>>();

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fr.vadc.FilesAndFoldersHelper.Exception
{
    public class FileOrFolderNotFoundException : System.Exception
    {
        public FileOrFolderNotFoundException()
        {
        }

        public FileOrFolderNotFoundException(string message)
            : base(message)
        {
        }

        public FileOrFolderNotFoundException(string message, System.Exception inner)
            : base(message, inner)
        {
        }
    }
}

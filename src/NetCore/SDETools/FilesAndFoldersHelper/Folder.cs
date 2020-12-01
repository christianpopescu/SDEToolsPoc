using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fr.vadc.FilesAndFoldersHelper
{
    public class Folder : IFileOrFolder
    {
         public string FullName { get; private set; }

         protected Folder() {}

         public static Folder ConstructFolder(string pFullName)
         {
             return new Folder() {FullName = pFullName};
         }
    }
}

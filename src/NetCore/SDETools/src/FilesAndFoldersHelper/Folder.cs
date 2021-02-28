using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fr.vadc.FilesAndFoldersHelper
{
    public class Folder : AbstractFileOrFolder
    {
        public readonly List<AbstractFileOrFolder> Content = new List<AbstractFileOrFolder>();
        
        protected Folder() {}

         public static Folder ConstructFolder(string pFullName)
         {
             return new Folder() {FullName = pFullName};
         }
    }
}

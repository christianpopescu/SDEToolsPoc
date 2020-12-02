using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fr.vadc.FilesAndFoldersHelper
{
    public class File : AbstractFileOrFolder
    {

        protected File(){}

        public static File ConstructFile(String pFullName)
        {
            return new File() {FullName = pFullName};
        }


    }
}

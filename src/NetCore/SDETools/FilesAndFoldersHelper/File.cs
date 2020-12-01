﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fr.vadc.FilesAndFoldersHelper
{
    public class File : IFileOrFolder
    {
        public string FullName { get; private set; }

        public readonly List<IFileOrFolder> Content = new List<IFileOrFolder>(); 

        protected File(){}

        public static File ConstructFile(String pFullName)
        {
            return new File() {FullName = pFullName};
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fr.vadc.FilesAndFoldersHelper
{
    public class FileWithData<T> : AbstractFileOrFolderWithData<T>
    {
        public static FileWithData<T> ConstructFileWithData<T>(String pFullName, Func<string,T> pFuncGetData)
        {
            return new FileWithData<T>()
            {
                FullName = pFullName,
                Data = pFuncGetData(pFullName)
            };
        }
    }
}

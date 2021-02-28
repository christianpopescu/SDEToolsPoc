using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using fr.vadc.AbstractDataHelper.Collections;

namespace SDEToolsConsole
{
    public class AbstractDataHelperTest
    {
        public static void ReadWriteList()
        {
            ListOfElements<string> loe =
                ListOfElements<string>.CreateListOfElements<string>((x) => x, (x) => x);

            loe.ReadFromFile(@"E:\Temp\ToDelete\file1.txt");
            loe.TheList.Add("tititi");
            loe.WriteToFile(@"E:\Temp\ToDelete\file11.txt");
        }
    }
}

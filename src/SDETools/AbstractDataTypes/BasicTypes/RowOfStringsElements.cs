using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractDataTypes.BasicTypes
{

    /// <summary>
    /// The purpose of this class is to memorize a row of a table. For the moment we'll keep only strings
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class RowOfStringsElements 
    {
        protected int NumberOfElements;
        protected IList<StringElement> List;

        public RowOfStringsElements(IList<StringElement> initList)
        {
            List = initList;
            NumberOfElements = initList.Count();
        }
        
        protected RowOfStringsElements()
        {
            List = new List<StringElement>();
            NumberOfElements = 0;
        }

        public IReadOnlyList<StringElement> GetList()
        {
            return (IReadOnlyList<StringElement>)List;
        }
    }
}

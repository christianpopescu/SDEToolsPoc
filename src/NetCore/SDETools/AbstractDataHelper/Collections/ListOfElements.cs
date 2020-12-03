using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fr.vadc.AbstractDataHelper.Collections
{
    /// <summary>
    /// Responsibility:
    /// - Read from file / Write to file
    /// - Compare lists
    /// - ...
    /// Constraint:
    /// - T could be represented as 1 line string
    /// </summary>
    /// <typeparam name="T"></typeparam>
    
    public class ListOfElements<T> 
    {
        public readonly List<T> TheList = new List<T>();

        protected Func<T, string> ToLine;
        protected Func<string, T> FromLine;

        public static ListOfElements<T> CreateListOfElements<T> (Func<T, string> pToLine, Func<string, T>pFromLine)
        {
            return new ListOfElements<T>()
            {
                ToLine = pToLine, FromLine = pFromLine

            };
        }


    }
}

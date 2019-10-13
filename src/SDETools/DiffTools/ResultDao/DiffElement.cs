using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiffTools
{
    public class DiffElement<T>
    {
        public int Index { get; set; }
        public T Value {get; set;}
        
        public  DiffElement(int pIndex, T pValue)
        {
            Index = pIndex;
            Value = pValue;
        }
    }
}

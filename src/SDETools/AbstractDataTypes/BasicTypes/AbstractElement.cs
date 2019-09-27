using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractDataTypes.BasicTypes
{
    public interface IElement {}
    public class AbstractElement<T> : IElement
    {
        public AbstractElement(T value)
        {
            Value = value;
        }

        public AbstractElement()
        {
            Value = default(T);
        }



        public T Value { get; set; }

        public override string ToString()
        {
            return Value.ToString();
        }

        //public override bool Equals(object obj)
        //{
        //    return base.Equals(obj);
        //}

        public override int GetHashCode() => Value.GetHashCode();
    }
}

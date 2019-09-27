using System;

namespace AbstractDataTypes.BasicTypes
{
    public class StringElement : AbstractElement<String>
    {
        public StringElement(String str) : base(str) {}

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string ToString()
        {
            return base.ToString();
        }

        public static implicit operator StringElement(String str) => new StringElement(str);
    }
}

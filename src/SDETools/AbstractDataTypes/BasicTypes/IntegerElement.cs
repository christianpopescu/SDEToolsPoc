namespace AbstractDataTypes.BasicTypes
{
    public class IntegerElement : AbstractElement<int>
    {
        public  IntegerElement(int i) : base(i) {}

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string ToString()
        {
            return base.ToString();
        }

        public static implicit operator IntegerElement(int i) => new IntegerElement(i);

    }
}
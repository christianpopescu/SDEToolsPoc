namespace DiffTools.ResultDao
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

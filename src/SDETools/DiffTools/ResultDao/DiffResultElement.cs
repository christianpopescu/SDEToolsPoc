namespace DiffTools.ResultDao
{
    public class DiffResultElement<T>
    {
        public DiffResultElement(DiffElement<T> first, DiffElement<T> second)
        {
            First = first;
            Second = second;
        }

        public DiffElement<T> First {get; set;}
        public DiffElement<T> Second {get; set;}


    }
}

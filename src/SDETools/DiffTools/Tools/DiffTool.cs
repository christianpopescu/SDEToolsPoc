using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiffTools
{
    public class DiffTool<T> where T :IEquatable<T>
    {
        public static readonly DiffElement<T> NullElement = new DiffElement<T>() {Index = 0, Value = default(T)};
        public static IList<DiffResultElement<T>> CompareForEquality(IList<T> pFirstToCompare,
            IList<T> pSecondToCompare)
        {
            List<DiffResultElement<T>> diffResults = new List<DiffResultElement<T>>();


            return diffResults;
        }
    }
}

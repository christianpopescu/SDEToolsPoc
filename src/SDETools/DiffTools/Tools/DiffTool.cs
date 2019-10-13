using System;
using System.Collections.Generic;
using System.Linq;
using DiffTools.ResultDao;

namespace DiffTools.Tools
{
    public class DiffTool<T> where T :IEquatable<T>
    {
        public static readonly DiffElement<T> NullElement = new DiffElement<T>(0, default(T));
        public static IList<DiffResultElement<T>> CompareForEquality(IList<T> pFirstToCompare,
            IList<T> pSecondToCompare)
        {
            long min = Math.Min(pFirstToCompare.Count(), pSecondToCompare.Count());
            IList<T> maxList = (pSecondToCompare.Count() == min) ? pFirstToCompare : pSecondToCompare ;
            List<DiffResultElement<T>> diffResults = new List<DiffResultElement<T>>();
            for (int i = 0; i < min; i++)
            {
                if (!pFirstToCompare.Equals(pSecondToCompare))
                {
                    diffResults.Add(new DiffResultElement<T>(new DiffElement<T>(i, pFirstToCompare[i]),
                        new DiffElement<T>(i, pSecondToCompare[i])));
                }
            }

            return diffResults;
        }
    }
}

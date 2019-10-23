using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using DiffTools.ResultDao;
using DiffTools.Tools;

namespace DiffToolsTest.Tools
{
    [TestFixture]
    public class DiffToolsTest
    {
        [Test]
        public void CompareForEqualityListOfStrings_EqualsList()
        {
            List<string> firstList = new List<string>() {"1", "2"};
            List<string> secondList = new List<string>() {"1", "2"};

            Assert.AreEqual(0, DiffTool<string>.CompareForEquality(firstList, secondList).Count());

        }
    }
}

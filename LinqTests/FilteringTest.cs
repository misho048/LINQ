using LINQ;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;

namespace LinqTests
{
    [TestClass]
    public class FilteringTest
    {
        [TestMethod]
        public void TestWhere01()
        {
            IEnumerable<int> actual = Filtering.Where01();
            IEnumerable<int> expected = new int[] { 4, 1, 3, 2, 0 };

            CollectionAssert.AreEqual(actual.ToList(), expected.ToList());
        }
    }
}

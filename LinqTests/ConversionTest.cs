using LINQ;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace LinqTests
{
    [TestClass]
    public class ConversionTest
    {
        [TestMethod]
        public void TestToArray()
        {
            double[] actual = Conversion.ToArray();
            double[] expected = new double[] { 4.1, 2.9, 2.3, 1.9, 1.7 };

            CollectionAssert.AreEqual(actual, expected, "You failed!");
        }

        [TestMethod]
        public void TestToList()
        {
            List<string> actual = Conversion.ToList();
            List<string> expected = new List<string> { "apple", "blueberry", "cherry" };

            CollectionAssert.AreEqual(actual, expected, "You failed!");
        }

        [TestMethod]
        public void TestToDictionary()
        {
            Dictionary<string, int> actual = Conversion.ToDictionary();
            Dictionary<string, int> expected = new Dictionary<string, int>() { { "Alice", 50 }, { "Bob", 40 }, { "Cathy", 45 } };

            Assert.AreEqual(true, actual.ContentEquals(expected), "You failed!");
        }

        [TestMethod]
        public void TestOfType()
        {
            IEnumerable<double> actual = Conversion.OfType();
            IEnumerable<double> expected = new double[] { 1.0, 7.0 };

            CollectionAssert.AreEqual(actual.ToList(), expected.ToList(), "You failed!");
        }
    }
}

using System.Collections.Generic;
using System.Linq;
using LINQ;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LinqTests
{
    [TestClass]
    public class QuantifiersTest
    {
        [TestMethod]
        public void TestAny01()
        {
            bool? actual = Quantifiers.Any01();
            bool? expected = true;

            Assert.AreEqual(actual, expected, "You failed!");
        }

        [TestMethod]
        public void TestAny02()
        {
            IEnumerable<string> actual = Quantifiers.Any02();
            IEnumerable<string> expected = new string[] { "Condiments", "Meat/Poultry", "Dairy Products" };

            CollectionAssert.AreEqual(actual.ToList(), expected.ToList(), "You failed!");
        }

        [TestMethod]
        public void TestAll01()
        {
            bool? actual = Quantifiers.All01();
            bool? expected = true;

            Assert.AreEqual(actual, expected, "You failed!");
        }

        [TestMethod]
        public void TestAll02()
        {
            IEnumerable<string> actual = Quantifiers.All02();
            IEnumerable<string> expected = new string[] { "Beverages", "Produce", "Seafood", "Confections", "Grains/Cereals" };

            CollectionAssert.AreEqual(actual.ToList(), expected.ToList(), "You failed!");
        }
    }
}

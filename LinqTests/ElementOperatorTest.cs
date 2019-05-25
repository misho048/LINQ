using LINQ;
using LINQ.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LinqTests
{
    [TestClass]
    public class ElementOperatorTest
    {
        [TestMethod]
        public void TestFirst01()
        {
            Product actual = ElementOperators.First01();
            Product expected = new Product { ProductID = 16, ProductName = "Pavlova", Category = "Confections", UnitPrice = 17.4500M, UnitsInStock = 29 };

            Assert.AreEqual(actual, expected, "You failed!");
        }

        [TestMethod]
        public void TestFirst02()
        {
            string actual = ElementOperators.First02();
            string expected = "one";

            Assert.AreEqual(actual, expected, "You failed!");
        }

        [TestMethod]
        public void TestFirstOrDefault01()
        {
            int actual = ElementOperators.FirstOrDefault01();
            int expected = 0;

            Assert.AreEqual(actual, expected, "You failed!");
        }

        [TestMethod]
        public void TestFirstOrDefault02()
        {
            Product actual = ElementOperators.FirstOrDefault02();
            Product expected = null;

            Assert.AreEqual(actual, expected, "You failed!");
        }

        [TestMethod]
        public void TestElementAt()
        {
            int actual = ElementOperators.ElementAt();
            int expected = 8;

            Assert.AreEqual(actual, expected, "You failed!");
        }
    }
}

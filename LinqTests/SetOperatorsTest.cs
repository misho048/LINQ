using System.Collections.Generic;
using System.Linq;
using LINQ;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LinqTests
{
    [TestClass]
    public class SetOperatorsTest
    {
        [TestMethod]
        public void TestDistinct01()
        {
            IEnumerable<int> actual = SetOperators.Distinct01();
            IEnumerable<int> expected = new int[] { 2, 3, 5 };

            CollectionAssert.AreEqual(actual.ToList(), expected.ToList(), "You failed!");
        }

        [TestMethod]
        public void TestDistinct02()
        {
            IEnumerable<string> actual = SetOperators.Distinct02();
            IEnumerable<string> expected =
                new string[] {
                    "Beverages",
                    "Condiments",
                    "Produce",
                    "Meat/Poultry",
                    "Seafood",
                    "Dairy Products",
                    "Confections",
                    "Grains/Cereals"
                };

            CollectionAssert.AreEqual(actual.ToList(), expected.ToList(), "You failed!");
        }

        [TestMethod]
        public void TestUnion01()
        {
            IEnumerable<int> actual = SetOperators.Union01();
            IEnumerable<int> expected = new int[] { 0, 2, 4, 5, 6, 8, 9, 1, 3, 7 };

            CollectionAssert.AreEqual(actual.ToList(), expected.ToList(), "You failed!");
        }

        [TestMethod]
        public void TestUnion02()
        {
            IEnumerable<char> actual = SetOperators.Union02();
            IEnumerable<char> expected = new char[] { 'C', 'A', 'G', 'U', 'N', 'M', 'I', 'Q', 'K', 'T', 'P', 'S', 'R', 'B',
                                                      'J', 'Z', 'V', 'F', 'E', 'W', 'L', 'O', 'D', 'H' };

            CollectionAssert.AreEqual(actual.ToList(), expected.ToList(), "You failed!");
        }

        [TestMethod]
        public void TestIntersect01()
        {
            IEnumerable<int> actual = SetOperators.Intersect01();
            IEnumerable<int> expected = new int[] { 5, 8 };

            CollectionAssert.AreEqual(actual.ToList(), expected.ToList(), "You failed!");
        }

        [TestMethod]
        public void TestIntersect02()
        {
            IEnumerable<char> actual = SetOperators.Intersect02();
            IEnumerable<char> expected = new char[] { 'C', 'A', 'G', 'N', 'M', 'I', 'Q', 'K', 'T', 'P', 'S', 'R', 'B',
                                                      'V', 'F', 'E', 'W', 'L', 'O' };

            CollectionAssert.AreEqual(actual.ToList(), expected.ToList(), "You failed!");
        }

        [TestMethod]
        public void TestExcept01()
        {
            IEnumerable<int> actual = SetOperators.Except01();
            IEnumerable<int> expected = new int[] { 0, 2, 4, 6, 9 };

            CollectionAssert.AreEqual(actual.ToList(), expected.ToList(), "You failed!");
        }

        [TestMethod]
        public void TestExcept02()
        {
            IEnumerable<char> actual = SetOperators.Except02();
            IEnumerable<char> expected = new char[] { 'U', 'J', 'Z' };

            CollectionAssert.AreEqual(actual.ToList(), expected.ToList(), "You failed!");
        }
    }
}

using LINQ;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace LinqTests
{
    [TestClass]
    public class GroupingTest
    {
        [TestMethod]
        public void TestGroupBy01()
        {
            Dictionary<int, int[]> actual = Grouping.GroupBy01();
            Dictionary<int, int[]> expected =
                new Dictionary<int, int[]>
                {
                    { 0, new int[] {5, 0} },
                    { 4, new int[] {4, 9} },
                    { 1, new int[] {1, 6} },
                    { 3, new int[] {3, 8} },
                    { 2, new int[] {7, 2} }
                };

            Assert.AreEqual(true, actual.ContentEquals<int, int[], int>(expected), "You failed!");
        }

        [TestMethod]
        public void TestGroupBy02()
        {
            Dictionary<char, string[]> actual = Grouping.GroupBy02();
            Dictionary<char, string[]> expected =
                new Dictionary<char, string[]>
                {
                    { 'b', new string[] { "blueberry", "banana" } },
                    { 'c', new string[] { "chimpanzee", "cheese" } },
                    { 'a', new string[] { "abacus", "apple" } }
                };

            Assert.AreEqual(true, actual.ContentEquals<char, string[], string>(expected), "You failed!");
        }
    }
}

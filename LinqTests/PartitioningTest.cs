using LINQ;
using LINQ.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;

namespace LinqTests
{
    [TestClass]
    public class PartitioningTest
    {
        [TestMethod]
        public void TestTake()
        {
            IEnumerable<int> actual = Partitioning.Take();
            IEnumerable<int> expected = new int[] { 5, 4, 1 };

            CollectionAssert.AreEqual(actual.ToList(), expected.ToList(), "You failed!");
        }

        [TestMethod]
        public void TestTakeNested()
        {
            IEnumerable<CustomerOrderDto> actual = Partitioning.TakeNested();
            IEnumerable<CustomerOrderDto> expected =
                new CustomerOrderDto[]
                {
                    new CustomerOrderDto() { CustomerId = "LAZYK", OrderId = 10482 },
                    new CustomerOrderDto() { CustomerId = "LAZYK", OrderId = 10545 },
                    new CustomerOrderDto() { CustomerId = "TRAIH", OrderId = 10574 }
                };

            CollectionAssert.AreEqual(actual.ToList(), expected.ToList(), "You failed!");
        }

        [TestMethod]
        public void TestSkip()
        {
            IEnumerable<int> actual = Partitioning.Skip();
            IEnumerable<int> expected = new int[] { 9, 8, 6, 7, 2, 0 };

            CollectionAssert.AreEqual(actual.ToList(), expected.ToList(), "You failed!");
        }

        [TestMethod]
        public void TestSkipNested()
        {
            IEnumerable<CustomerOrderDto> actual = Partitioning.SkipNested();
            IEnumerable<CustomerOrderDto> expected =
                new CustomerOrderDto[]
                {
                    new CustomerOrderDto() { CustomerId = "TRAIH", OrderId = 10574 },
                    new CustomerOrderDto() { CustomerId = "TRAIH", OrderId = 10577 },
                    new CustomerOrderDto() { CustomerId = "TRAIH", OrderId = 10822 },
                    new CustomerOrderDto() { CustomerId = "WHITC", OrderId = 10269 },
                    new CustomerOrderDto() { CustomerId = "WHITC", OrderId = 10344 },
                    new CustomerOrderDto() { CustomerId = "WHITC", OrderId = 10469 },
                    new CustomerOrderDto() { CustomerId = "WHITC", OrderId = 10483 },
                    new CustomerOrderDto() { CustomerId = "WHITC", OrderId = 10504 },
                    new CustomerOrderDto() { CustomerId = "WHITC", OrderId = 10596 },
                    new CustomerOrderDto() { CustomerId = "WHITC", OrderId = 10693 },
                    new CustomerOrderDto() { CustomerId = "WHITC", OrderId = 10696 },
                    new CustomerOrderDto() { CustomerId = "WHITC", OrderId = 10723 },
                    new CustomerOrderDto() { CustomerId = "WHITC", OrderId = 10740 },
                    new CustomerOrderDto() { CustomerId = "WHITC", OrderId = 10861 },
                    new CustomerOrderDto() { CustomerId = "WHITC", OrderId = 10904 },
                    new CustomerOrderDto() { CustomerId = "WHITC", OrderId = 11032 },
                    new CustomerOrderDto() { CustomerId = "WHITC", OrderId = 11066 }
                };

            CollectionAssert.AreEqual(actual.ToList(), expected.ToList(), "You failed!");
        }

        [TestMethod]
        public void TestTakeWhile()
        {
            IEnumerable<int> actual = Partitioning.TakeWhile();
            IEnumerable<int> expected = new int[] { 5, 4, 1, 3 };

            CollectionAssert.AreEqual(actual.ToList(), expected.ToList(), "You failed!");
        }

        [TestMethod]
        public void TestTakeWhileIndexed()
        {
            IEnumerable<int> actual = Partitioning.TakeWhileIndexed();
            IEnumerable<int> expected = new int[] { 5, 4 };

            CollectionAssert.AreEqual(actual.ToList(), expected.ToList(), "You failed!");
        }

        [TestMethod]
        public void TestSkipWhile()
        {
            IEnumerable<int> actual = Partitioning.SkipWhile();
            IEnumerable<int> expected = new int[] { 3, 9, 8, 6, 7, 2, 0 };

            CollectionAssert.AreEqual(actual.ToList(), expected.ToList(), "You failed!");
        }

        [TestMethod]
        public void TestSkipWhileIndexed()
        {
            IEnumerable<int> actual = Partitioning.SkipWhileIndexed();
            IEnumerable<int> expected = new int[] { 1, 3, 9, 8, 6, 7, 2, 0 };

            CollectionAssert.AreEqual(actual.ToList(), expected.ToList(), "You failed!");
        }
    }
}

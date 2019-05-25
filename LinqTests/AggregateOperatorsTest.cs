using System.Collections.Generic;
using LINQ;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LinqTests
{
    [TestClass]
    public class AggregateOperatorsTest
    {
        [TestMethod]
        public void TestCount01()
        {
            int actual = AggregateOperators.Count01();
            int expected = 3;

            Assert.AreEqual(actual, expected, "You failed!");
        }

        [TestMethod]
        public void TestCount02()
        {
            int actual = AggregateOperators.Count02();
            int expected = 5;

            Assert.AreEqual(actual, expected, "You failed!");
        }

        [TestMethod]
        public void TestCount03()
        {
            Dictionary<string, int> actual = AggregateOperators.Count03();
            Dictionary<string, int> expected =
                new Dictionary<string, int>
                {
                    { "ALFKI", 6 },
                    { "ANATR", 4 },
                    { "ANTON", 7 },
                    { "AROUT", 13 },
                    { "BERGS", 18 },
                    { "BLAUS", 7 },
                    { "BLONP", 11 },
                    { "BOLID", 3 },
                    { "BONAP", 17 },
                    { "BOTTM", 14 },
                    { "BSBEV", 10 },
                    { "CACTU", 6 },
                    { "CENTC", 1 },
                    { "CHOPS", 8 },
                    { "COMMI", 5 },
                    { "CONSH", 3 },
                    { "DRACD", 6 },
                    { "DUMON", 4 },
                    { "EASTC", 8 },
                    { "ERNSH", 30 } ,
                    { "FAMIA", 7 },
                    { "FISSA", 0 },
                    { "FOLIG", 5 },
                    { "FOLKO", 19 } ,
                    { "FRANK", 15 } ,
                    { "FRANR", 3 } ,
                    { "FRANS", 6 } ,
                    { "FURIB", 8 } ,
                    { "GALED", 5 } ,
                    { "GODOS", 10 } ,
                    { "GOURL", 9 } ,
                    { "GREAL", 11 } ,
                    { "GROSR", 2 } ,
                    { "HANAR", 14 } ,
                    { "HILAA", 18 } ,
                    { "HUNGC", 5 } ,
                    { "HUNGO", 19 } ,
                    { "ISLAT", 10 } ,
                    { "KOENE", 14 } ,
                    { "LACOR", 4 } ,
                    { "LAMAI", 14 } ,
                    { "LAUGB", 3 } ,
                    { "LAZYK", 2 } ,
                    { "LEHMS", 15 } ,
                    { "LETSS", 4 } ,
                    { "LILAS", 14 } ,
                    { "LINOD", 12 } ,
                    { "LONEP", 8 } ,
                    { "MAGAA", 10 } ,
                    { "MAISD", 7 } ,
                    { "MEREP", 13 } ,
                    { "MORGK", 5 } ,
                    { "NORTS", 3 } ,
                    { "OCEAN", 5 } ,
                    { "OLDWO", 10 } ,
                    { "OTTIK", 9 } ,
                    { "PARIS", 0 } ,
                    { "PERIC", 6 } ,
                    { "PICCO", 10 } ,
                    { "PRINI", 6 } ,
                    { "QUEDE", 9 } ,
                    { "QUEEN", 13 } ,
                    { "QUICK", 28 } ,
                    { "RANCH", 5 } ,
                    { "RATTC", 18 } ,
                    { "REGGC", 12 } ,
                    { "RICAR", 11 } ,
                    { "RICSU", 10 } ,
                    { "ROMEY", 5 } ,
                    { "SANTG", 6 } ,
                    { "SAVEA", 31 } ,
                    { "SEVES", 9 } ,
                    { "SIMOB", 7 } ,
                    { "SPECD", 4 } ,
                    { "SPLIR", 9 } ,
                    { "SUPRD", 12 } ,
                    { "THEBI", 4 } ,
                    { "THECR", 3 } ,
                    { "TOMSP", 5 } ,
                    { "TORTU", 10 } ,
                    { "TRADH", 7 } ,
                    { "TRAIH", 3 } ,
                    { "VAFFE", 11 } ,
                    { "VICTE", 10 } ,
                    { "VINET", 4 } ,
                    { "WANDK", 10 } ,
                    { "WARTH", 15 } ,
                    { "WELLI", 9 } ,
                    { "WHITC", 14 } ,
                    { "WILMK", 8 } ,
                    { "WOLZA", 7 }
                };

            Assert.AreEqual(true, actual.ContentEquals(expected), "You failed!");
        }

        [TestMethod]
        public void TestCount04()
        {
            Dictionary<string, int> actual = AggregateOperators.Count04();
            Dictionary<string, int> expected =
                new Dictionary<string, int>
                {
                    { "Beverages", 12 },
                    { "Condiments", 12},
                    { "Produce", 5 },
                    { "Meat/Poultry", 6 },
                    { "Seafood", 12 },
                    { "Dairy Products", 10 },
                    { "Confections", 13 },
                    { "Grains/Cereals", 7 }
                };

            Assert.AreEqual(true, actual.ContentEquals(expected), "You failed!");
        }

        [TestMethod]
        public void TestSum01()
        {
            int actual = AggregateOperators.Sum01();
            int expected = 45;

            Assert.AreEqual(actual, expected, "You failed!");
        }

        [TestMethod]
        public void TestSum02()
        {
            int actual = AggregateOperators.Sum02();
            int expected = 20;

            Assert.AreEqual(actual, expected, "You failed!");
        }

        [TestMethod]
        public void TestSum03()
        {
            Dictionary<string, int> actual = AggregateOperators.Sum03();
            Dictionary<string, int> expected =
                new Dictionary<string, int>
                {
                    { "Beverages", 559 },
                    { "Condiments", 507 },
                    { "Produce", 100 },
                    { "Meat/Poultry", 165 },
                    { "Seafood", 701 },
                    { "Dairy Products", 393 },
                    { "Confections", 386 },
                    { "Grains/Cereals", 308 }
                };

            Assert.AreEqual(true, actual.ContentEquals(expected), "You failed!");
        }

        [TestMethod]
        public void TestMin01()
        {
            int actual = AggregateOperators.Min01();
            int expected = 0;

            Assert.AreEqual(actual, expected, "You failed!");
        }

        [TestMethod]
        public void TestMin02()
        {
            int actual = AggregateOperators.Min02();
            int expected = 5;

            Assert.AreEqual(actual, expected, "You failed!");
        }

        [TestMethod]
        public void TestMin03()
        {
            Dictionary<string, decimal> actual = AggregateOperators.Min03();
            Dictionary<string, decimal> expected =
                new Dictionary<string, decimal>
                {
                    { "Beverages", 4.5M },
                    { "Condiments", 10M },
                    { "Produce", 10M },
                    { "Meat/Poultry", 7.45M },
                    { "Seafood", 6M },
                    { "Dairy Products", 2.5M },
                    { "Confections", 9.2M },
                    { "Grains/Cereals", 7M }
                };

            Assert.AreEqual(true, actual.ContentEquals(expected), "You failed!");
        }

        [TestMethod]
        public void TestMax01()
        {
            int actual = AggregateOperators.Max01();
            int expected = 9;

            Assert.AreEqual(actual, expected, "You failed!");
        }

        [TestMethod]
        public void TestMax02()
        {
            int actual = AggregateOperators.Max02();
            int expected = 9;

            Assert.AreEqual(actual, expected, "You failed!");
        }

        [TestMethod]
        public void TestMax03()
        {
            Dictionary<string, decimal> actual = AggregateOperators.Max03();
            Dictionary<string, decimal> expected =
                new Dictionary<string, decimal>
                {
                    { "Beverages", 263.5M },
                    { "Condiments", 43.9M },
                    { "Produce", 53M },
                    { "Meat/Poultry", 123.79M },
                    { "Seafood", 62.5M },
                    { "Dairy Products", 55M },
                    { "Confections", 81M },
                    { "Grains/Cereals", 38M }
                };

            Assert.AreEqual(true, actual.ContentEquals(expected), "You failed!");
        }

        [TestMethod]
        public void TestAverage01()
        {
            double actual = AggregateOperators.Average01();
            double expected = 4.5;

            Assert.AreEqual(actual, expected, "You failed!");
        }

        [TestMethod]
        public void TestAverage02()
        {
            double actual = AggregateOperators.Average02();
            double expected = 6.666666666666667;

            Assert.AreEqual(actual, expected, "You failed!");
        }

        [TestMethod]
        public void TestAverage03()
        {
            Dictionary<string, decimal> actual = AggregateOperators.Average03();
            Dictionary<string, decimal> expected =
                new Dictionary<string, decimal>
                {
                    { "Beverages", 37.979166666666666666666666667M },
                    { "Condiments", 23.0625M },
                    { "Produce", 32.3700M },
                    { "Meat/Poultry", 54.006666666666666666666666667M },
                    { "Seafood", 20.6825M },
                    { "Dairy Products", 28.7300M },
                    { "Confections", 25.1600M },
                    { "Grains/Cereals", 20.2500M }
                };

            Assert.AreEqual(true, actual.ContentEquals(expected), "You failed!");
        }
    }
}

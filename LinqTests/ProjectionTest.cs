using System.Collections.Generic;
using System.Linq;
using LINQ;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LinqTests
{
    [TestClass]
    public class ProjectionTest
    {
        [TestMethod]
        public void TestSelect01()
        {
            IEnumerable<int> actual = Projection.Select01();
            IEnumerable<int> expected = new int[] { 6, 5, 2, 4, 10, 9, 7, 8, 3, 1 };

            CollectionAssert.AreEqual(actual.ToList(), expected.ToList(), "You failed!");
        }

        [TestMethod]
        public void TestSelect02()
        {
            IEnumerable<string> actual = Projection.Select02();
            IEnumerable<string> expected =
                new string[] {
                    "Chai", "Chang", "Aniseed Syrup", "Chef Anton's Cajun Seasoning", "Chef Anton's Gumbo Mix",
                    "Grandma's Boysenberry Spread", "Uncle Bob's Organic Dried Pears", "Northwoods Cranberry Sauce",
                    "Mishi Kobe Niku", "Ikura", "Queso Cabrales", "Queso Manchego La Pastora", "Konbu",
                    "Tofu", "Genen Shouyu", "Pavlova", "Alice Mutton", "Carnarvon Tigers", "Teatime Chocolate Biscuits",
                    "Sir Rodney's Marmalade", "Sir Rodney's Scones", "Gustaf's Knäckebröd",  "Tunnbröd",
                    "Guaraná Fantástica", "NuNuCa Nuß-Nougat-Creme", "Gumbär Gummibärchen", "Schoggi Schokolade",
                    "Rössle Sauerkraut", "Thüringer Rostbratwurst", "Nord-Ost Matjeshering", "Gorgonzola Telino",
                    "Mascarpone Fabioli", "Geitost", "Sasquatch Ale", "Steeleye Stout", "Inlagd Sill",
                    "Gravad lax", "Côte de Blaye", "Chartreuse verte", "Boston Crab Meat", "Jack's New England Clam Chowder",
                    "Singaporean Hokkien Fried Mee", "Ipoh Coffee", "Gula Malacca", "Rogede sild", "Spegesild",
                    "Zaanse koeken", "Chocolade", "Maxilaku", "Valkoinen suklaa", "Manjimup Dried Apples",
                    "Filo Mix", "Perth Pasties", "Tourtière", "Pâté chinois", "Gnocchi di nonna Alice",
                    "Ravioli Angelo", "Escargots de Bourgogne", "Raclette Courdavault", "Camembert Pierrot",
                    "Sirop d'érable", "Tarte au sucre", "Vegie-spread", "Wimmers gute Semmelknödel",
                    "Louisiana Fiery Hot Pepper Sauce", "Louisiana Hot Spiced Okra", "Laughing Lumberjack Lager",
                    "Scottish Longbreads", "Gudbrandsdalsost", "Outback Lager", "Flotemysost", "Mozzarella di Giovanni",
                    "Röd Kaviar", "Longlife Tofu", "Rhönbräu Klosterbier", "Lakkalikööri", "Original Frankfurter grüne Soße"
                };

            CollectionAssert.AreEqual(actual.ToList(), expected.ToList(), "You failed!");
        }

        [TestMethod]
        public void TestSelectTransformation()
        {
            IEnumerable<string> actual = Projection.SelectTransformation();
            IEnumerable<string> expected = new string[] { "five", "four", "one", "three", "nine", "eight", "six", "seven", "two", "zero" };

            CollectionAssert.AreEqual(actual.ToList(), expected.ToList(), "You failed!");
        }

        [TestMethod]
        public void TestSelectAnonymousTypes01()
        {
            IEnumerable<string> actual = Projection.SelectAnonymousTypes01();
            IEnumerable<string> expected =
                new string[] {
                    "Uppercase: APPLE, Lowercase: apple",
                    "Uppercase: BLUEBERRY, Lowercase: blueberry",
                    "Uppercase: CHERRY, Lowercase: cherry"
                };

            CollectionAssert.AreEqual(actual.ToList(), expected.ToList(), "You failed!");
        }

        [TestMethod]
        public void TestSelectAnonymousTypes02()
        {
            IEnumerable<string> actual = Projection.SelectAnonymousTypes02();
            IEnumerable<string> expected =
                new string[] {
                    "The digit five is odd.",
                    "The digit four is even.",
                    "The digit one is odd.",
                    "The digit three is odd.",
                    "The digit nine is odd.",
                    "The digit eight is even.",
                    "The digit six is even.",
                    "The digit seven is odd.",
                    "The digit two is even.",
                    "The digit zero is even."
                };

            CollectionAssert.AreEqual(actual.ToList(), expected.ToList(), "You failed!");
        }

        [TestMethod]
        public void TestSelectIndexed()
        {
            IEnumerable<string> actual = Projection.SelectIndexed();
            IEnumerable<string> expected =
                new string[] {
                    "5: False",
                    "4: False",
                    "1: False",
                    "3: True",
                    "9: False",
                    "8: False",
                    "6: True",
                    "7: True",
                    "2: False",
                    "0: False"
                };

            CollectionAssert.AreEqual(actual.ToList(), expected.ToList(), "You failed!");
        }

        [TestMethod]
        public void TestSelectFiltered()
        {
            IEnumerable<string> actual = Projection.SelectFiltered();
            IEnumerable<string> expected = new string[] { "four", "one", "three", "two", "zero" };

            CollectionAssert.AreEqual(actual.ToList(), expected.ToList(), "You failed!");
        }

        [TestMethod]
        public void TestSelectMany()
        {
            IEnumerable<string> actual = Projection.SelectMany();
            IEnumerable<string> expected =
                new string[] {
                    "CustomerID=LAZYK OrderID=10482",
                    "CustomerID=LAZYK OrderID=10545",
                    "CustomerID=TRAIH OrderID=10574",
                    "CustomerID=TRAIH OrderID=10577",
                    "CustomerID=TRAIH OrderID=10822",
                    "CustomerID=WHITC OrderID=10469",
                    "CustomerID=WHITC OrderID=10483",
                    "CustomerID=WHITC OrderID=10504",
                    "CustomerID=WHITC OrderID=10596",
                    "CustomerID=WHITC OrderID=10693",
                    "CustomerID=WHITC OrderID=10696",
                    "CustomerID=WHITC OrderID=10723",
                    "CustomerID=WHITC OrderID=10740",
                    "CustomerID=WHITC OrderID=10861",
                    "CustomerID=WHITC OrderID=10904",
                    "CustomerID=WHITC OrderID=11032",
                    "CustomerID=WHITC OrderID=11066"
                };

            CollectionAssert.AreEqual(actual.ToList(), expected.ToList(), "You failed!");
        }
    }
}
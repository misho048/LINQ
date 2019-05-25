using LINQ.Data;
using LINQ.Models;
using System.Collections.Generic;
using System.Linq;

namespace LINQ
{
    public static class AggregateOperators
    {
        /// <summary>
        /// Returns the number of unique factors of 300.
        /// </summary>
        /// <returns>Number of unique factors of 300.</returns>
        public static int Count01()
        {
            int[] factorsOf300 = { 2, 2, 3, 5, 5 };

            // !!! INSERT YOUR LINQ  MAGIC HERE !!!
            
            return 42;
        }

        /// <summary>
        /// Returns the number of odd ints in the array.
        /// </summary>
        /// <returns>Number of odd ints in the array.</returns>
        public static int Count02()
        {
            int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            // !!! INSERT YOUR LINQ  MAGIC HERE !!!
            
            return 42;
        }

        /// <summary>
        /// Returns list of customers and how many orders each has.
        /// </summary>
        /// <returns>Dictionary where key is customer ID and value is count of their orders.</returns>
        public static Dictionary<string, int> Count03()
        {
            List<Customer> customers = DataLoader.GetCustomerList();

            // !!! INSERT YOUR LINQ  MAGIC HERE !!!
            
            return new Dictionary<string, int>();
        }

        /// <summary>
        /// Returns list of categories and how many products each has.
        /// </summary>
        /// <returns>Dictionary where key is category name and value is count of their products.</returns>
        public static Dictionary<string, int> Count04()
        {
            List<Product> products = DataLoader.GetProductList();

            // !!! INSERT YOUR LINQ  MAGIC HERE !!!
            
            return new Dictionary<string, int>();
        }

        /// <summary>
        /// Returns the total of the numbers in an array.
        /// </summary>
        /// <returns>Total of the numbers in an array.</returns>
        public static int Sum01()
        {
            int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            // !!! INSERT YOUR LINQ  MAGIC HERE !!!
            
            return 0;
        }

        /// <summary>
        /// Returns the total number of characters of all words in the array.
        /// </summary>
        /// <returns>Total number of characters of all words in the array.</returns>
        public static int Sum02()
        {
            string[] words = { "cherry", "apple", "blueberry" };

            // !!! INSERT YOUR LINQ  MAGIC HERE !!!
            
            return 0;
        }

        /// <summary>
        /// Returns the total units in stock for each product category.
        /// </summary>
        /// <returns>Dictionary where key is category name and value is sum of their products' units.</returns>
        public static Dictionary<string, int> Sum03()
        {
            List<Product> products = DataLoader.GetProductList();

            // !!! INSERT YOUR LINQ  MAGIC HERE !!!
            
            return new Dictionary<string, int>();
        }

        /// <summary>
        /// Returns the lowest number in an array.
        /// </summary>
        /// <returns>The lowest number in an array.</returns>
        public static int Min01()
        {
            int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            // !!! INSERT YOUR LINQ  MAGIC HERE !!!
            
            return 42;
        }

        /// <summary>
        /// Returns the length of the shortest word in an array.
        /// </summary>
        /// <returns>Length of the shortest word in an array.</returns>
        public static int Min02()
        {
            string[] words = { "cherry", "apple", "blueberry" };

            // !!! INSERT YOUR LINQ  MAGIC HERE !!!
            
            return 0;
        }

        /// <summary>
        /// Returns the cheapest price among each category's products.
        /// </summary>
        /// <returns>Dictionary where key is category name and value is the cheapest price among its products.</returns>
        public static Dictionary<string, decimal> Min03()
        {
            List<Product> products = DataLoader.GetProductList();

            // !!! INSERT YOUR LINQ  MAGIC HERE !!!
            
            return new Dictionary<string, decimal>();
        }

        /// <summary>
        /// Returns the highest number in an array.
        /// </summary>
        /// <returns>The highest number in an array.</returns>
        public static int Max01()
        {
            int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            // !!! INSERT YOUR LINQ  MAGIC HERE !!!
            
            return -1;
        }

        /// <summary>
        /// Returns the length of the longest word in an array.
        /// </summary>
        /// <returns>Length of the longest word in an array.</returns>
        public static int Max02()
        {
            string[] words = { "cherry", "apple", "blueberry" };

            // !!! INSERT YOUR LINQ  MAGIC HERE !!!
            
            return 0;
        }

        /// <summary>
        /// Returns the most expensive price among each category's products.
        /// </summary>
        /// <returns>Dictionary where key is category name and value is the most expensive price among its products.</returns>
        public static Dictionary<string, decimal> Max03()
        {
            List<Product> products = DataLoader.GetProductList();

            // !!! INSERT YOUR LINQ  MAGIC HERE !!!
            
            return new Dictionary<string, decimal>();
        }

        /// <summary>
        /// Returns the average of all numbers in an array.
        /// </summary>
        /// <returns>The average of all numbers in an array.</returns>
        public static double Average01()
        {
            int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            // !!! INSERT YOUR LINQ  MAGIC HERE !!!
            
            return -1;
        }

        /// <summary>
        /// Returns the average length of the words in the array.
        /// </summary>
        /// <returns>Average length of the words in the array.</returns>
        public static double Average02()
        {
            string[] words = { "cherry", "apple", "blueberry" };

            // !!! INSERT YOUR LINQ  MAGIC HERE !!!
            
            return 0;
        }

        /// <summary>
        /// Returns the average price of each category's products.
        /// </summary>
        /// <returns>Dictionary where key is category name and value is the average price of its products.</returns>
        public static Dictionary<string, decimal> Average03()
        {
            List<Product> products = DataLoader.GetProductList();

            // !!! INSERT YOUR LINQ  MAGIC HERE !!!
            
            return new Dictionary<string, decimal>();
        }
    }
}

using LINQ.Data;
using LINQ.Models;
using System.Collections.Generic;
using System.Linq;

namespace LINQ
{
    public static class SetOperators
    {
        /// <summary>
        /// Removes duplicate elements in a sequence of factors of 300.
        /// </summary>
        /// <returns>Collection with unique factors of 300.</returns>
        public static IEnumerable<int> Distinct01()
        {
            int[] factorsOf300 = { 2, 2, 3, 5, 5 };

            // !!! INSERT YOUR LINQ  MAGIC HERE !!!

            return new int[] { };
        }

        /// <summary>
        /// Reurns unique product category names.
        /// </summary>
        /// <returns>Collection with unique product category names.</returns>
        public static IEnumerable<string> Distinct02()
        {
            List<Product> products = DataLoader.GetProductList();

            // !!! INSERT YOUR LINQ  MAGIC HERE !!!

            return new string[] { };
        }

        /// <summary>
        /// Reurns one sequence that contains the unique values from two arrays.
        /// </summary>
        /// <returns>Collection with unique values from two arrays.</returns>
        public static IEnumerable<int> Union01()
        {
            int[] numbersA = { 0, 2, 4, 5, 6, 8, 9 };
            int[] numbersB = { 1, 3, 5, 7, 8 };

            // !!! INSERT YOUR LINQ  MAGIC HERE !!!

            return new int[] { };
        }

        /// <summary>
        /// Reurns one sequence that contains unique first letter from both product and customer names.
        /// </summary>
        /// <returns>Collection with unique first letter from both product and customer names.</returns>
        public static IEnumerable<char> Union02()
        {
            List<Product> products = DataLoader.GetProductList();
            List<Customer> customers = DataLoader.GetCustomerList();

            // !!! INSERT YOUR LINQ  MAGIC HERE !!!

            return new char[] { };
        }

        /// <summary>
        /// Reurns one sequence that contains the common values shared by two arrays.
        /// </summary>
        /// <returns>Collection with common values shared by two arrays.</returns>
        public static IEnumerable<int> Intersect01()
        {
            int[] numbersA = { 0, 2, 4, 5, 6, 8, 9 };
            int[] numbersB = { 1, 3, 5, 7, 8 };

            // !!! INSERT YOUR LINQ  MAGIC HERE !!!

            return new int[] { };
        }

        /// <summary>
        /// Reurns one sequence that contains the common first letter from both product and customer names.
        /// </summary>
        /// <returns>Collection with common first letter from both product and customer names.</returns>
        public static IEnumerable<char> Intersect02()
        {
            List<Product> products = DataLoader.GetProductList();
            List<Customer> customers = DataLoader.GetCustomerList();

            // !!! INSERT YOUR LINQ  MAGIC HERE !!!

            return new char[] { };
        }

        /// <summary>
        /// Reurns one sequence that contains the values from numbersA that are not also in numbersB.
        /// </summary>
        /// <returns>Collection with values from numbersA that are not also in numbersB.</returns>
        public static IEnumerable<int> Except01()
        {
            int[] numbersA = { 0, 2, 4, 5, 6, 8, 9 };
            int[] numbersB = { 1, 3, 5, 7, 8 };

            // !!! INSERT YOUR LINQ  MAGIC HERE !!!

            return new int[] { };
        }

        /// <summary>
        /// Reurns one sequence that contains the first letters of product names that are not also first letters of customer names.
        /// </summary>
        /// <returns>Collection with first letters of product names that are not also first letters of customer names.</returns>
        public static IEnumerable<char> Except02()
        {
            List<Product> products = DataLoader.GetProductList();
            List<Customer> customers = DataLoader.GetCustomerList();

            // !!! INSERT YOUR LINQ  MAGIC HERE !!!

            return new char[] { };
        }
    }
}
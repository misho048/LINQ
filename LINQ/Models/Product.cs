using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ.Models
{
    public class Product
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public string Category { get; set; }
        public decimal UnitPrice { get; set; }
        public int UnitsInStock { get; set; }

        public override bool Equals(object obj)
        {
            if (obj is Product)
            {
                Product other = (Product)obj;
                return (ProductID == other.ProductID && ProductName.Equals(other.ProductName) && Category.Equals(other.Category) &&
                        UnitPrice == other.UnitPrice && UnitsInStock == other.UnitsInStock);
            }
            else
            {
                return false;
            }
        }

        public override int GetHashCode()
        {
            return ProductID;
        }
    }
}

namespace LINQ.Models
{
    public class Customer
    {
        public string CustomerID { get; set; }
        public string CompanyName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Region { get; set; }
        public string PostalCode { get; set; }
        public string Country { get; set; }
        public string Phone { get; set; }
        public string Fax { get; set; }
        public Order[] Orders { get; set; }
    }

    public class CustomerDto
    {
        public string CustomerId { get; set; }
        public int OrderCount { get; set; }

        public override bool Equals(object obj)
        {
            if (obj is CustomerDto)
            {
                CustomerDto other = (CustomerDto)obj;
                return (CustomerId.Equals(other.CustomerId) && OrderCount == other.OrderCount);
            }
            else
            {
                return false;
            }
        }

        public override int GetHashCode()
        {
            return CustomerId.GetHashCode();
        }
    }

    public class CustomerOrderDto
    {
        public string CustomerId { get; set; }
        public int OrderId { get; set; }

        public override bool Equals(object obj)
        {
            if (obj is CustomerOrderDto)
            {
                CustomerOrderDto other = (CustomerOrderDto)obj;
                return (CustomerId.Equals(other.CustomerId) && OrderId == other.OrderId);
            }
            else
            {
                return false;
            }
        }

        public override int GetHashCode()
        {
            return CustomerId.GetHashCode();
        }
    }
}

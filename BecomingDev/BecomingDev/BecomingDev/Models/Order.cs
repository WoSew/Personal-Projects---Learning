using System;

namespace BecomingDev.Models
{
    public class Order
    {
        public int Id { get; private set; }
        public decimal Price { get; private set; }
        public decimal TaxRate { get; } = 0.23M; // M - monety, it means decimal type (double type - without "M" at the end of the word"
        public decimal TotalPrice { get { return (1 + TaxRate) * Price; }}  // price with tax rate

        public bool IsPurchased { get; private set; }

        public Order(int id, decimal price)
        {
            if (price <= 0)
            {
                throw new Exception("Price must be greater than 0.");
            }

            Id = id;
            Price = price;
        }

        public void Purchase() // zakup
        {
            if (IsPurchased)
            {
                throw new Exception("Order was already purchased.");
            }

            IsPurchased = true;
        }
    }
}
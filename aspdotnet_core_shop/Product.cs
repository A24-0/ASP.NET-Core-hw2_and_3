using Microsoft.AspNetCore.Mvc;

namespace aspdotnet_core_shop
{
    public class Product
    {
        public Product(string name, decimal price)
        {
            if (string.IsNullOrEmpty(name))
            {
                throw new ArgumentNullException($"'{nameof(name)}' can't be null or empty", nameof(name));
            }
            if (price < 0)
            {
                throw new ArgumentNullException(nameof(price));
            }
            Name = name;
            Price = price;
        }

        public string Name { get; set; }
        public decimal Price { get; set; }
    }
}

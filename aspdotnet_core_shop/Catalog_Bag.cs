using System.Collections.Concurrent;

namespace aspdotnet_core_shop
{
    public class Catalog_Bag
    {
        private readonly ConcurrentBag<Product> _productsBag = new()
        {
            new("clean code", 500m),
            new("The code that fits in the head", 1000m),
            new("refactoring",  100m)
        };
        public Product[] GetProductsBag()
        {
            return _productsBag.ToArray();
        }

        public Product GetProductBag(string productName)
        {
            return _productsBag.First(p => p.Name == productName);
        }

        public void AddProductsBag(Product product)
        {
            _productsBag.Add(product);
        }
        public Product RemoveProductBag(Product product)
        {
            _productsBag.TryTake(out product);
            return product;
        }

    }
}

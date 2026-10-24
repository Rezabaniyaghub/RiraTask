
using RiraTask.Enums;
using RiraTask.Models;

namespace RiraTask.Services
{
    public class ProductService : ProductServiceBase
    {
        private readonly List<Product> _products;

        public ProductService(List<Product> products)
        {
            _products = products;
        }

        // Retrieves products belonging to the specified category.
        public override List<Product> GetProductsByCategory(Categories category)
        {
            return _products
                .Where(product => product.Category == category)
                .ToList();
        }

        // Finds the product with the highest price.
        public override Product? GetMostExpensiveProduct()
        {
            return _products
                .OrderByDescending(product => product.Price)
                .FirstOrDefault();
        }

        // Calculates the total price of all products.
        public override decimal GetTotalPrice()
        {
            return _products.Sum(product => product.Price);
        }

        // Groups products by category.
        public override IEnumerable<IGrouping<Categories, Product>> GetProductsGroupedByCategory()
        {
            return _products.GroupBy(product => product.Category);
        }

        // Calculates the average price of all products.
        public override decimal GetAveragePrice()
        {
            return _products.Average(product => product.Price);
        }
    }
}

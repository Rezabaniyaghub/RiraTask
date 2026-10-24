using RiraTask.Enums;
using RiraTask.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RiraTask.Services
{
    public abstract class ProductServiceBase
    {
        public abstract List<Product> GetProductsByCategory(Categories categories);

        public abstract Product? GetMostExpensiveProduct();

        public abstract decimal GetTotalPrice();

        public abstract IEnumerable<IGrouping<Categories, Product>> GetProductsGroupedByCategory();

        public abstract decimal GetAveragePrice();
    }
}

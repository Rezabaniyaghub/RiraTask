using RiraTask.Data;
using RiraTask.Enums;
using RiraTask.Services;

var service = new ProductService(ProductData.Products);

// 1. Get products by category
var products = service.GetProductsByCategory(Categories.Category1);

Console.WriteLine("Products in Category1:");

foreach (var product in products)
{
    Console.WriteLine($"{product.Name} - {product.Price}");
}

// 2. Find the most expensive product
var mostExpensiveProduct = service.GetMostExpensiveProduct();

Console.WriteLine("\nMost Expensive Product:");

if (mostExpensiveProduct != null)
{
    Console.WriteLine($"{mostExpensiveProduct.Name} - {mostExpensiveProduct.Price}");
}
else
{
    Console.WriteLine("No products found.");
}

// 3. Calculate the total price
var totalPrice = service.GetTotalPrice();

Console.WriteLine($"\nTotal Price: {totalPrice}");

// 4. Group products by category
var groupedProducts = service.GetProductsGroupedByCategory();

Console.WriteLine("\nProducts Grouped by Category:");

foreach (var group in groupedProducts)
{
    Console.WriteLine($"\n{group.Key}:");

    foreach (var product in group)
    {
        Console.WriteLine($"- {product.Name} - {product.Price}");
    }
}

// 5. Calculate the average price
var averagePrice = service.GetAveragePrice();

Console.WriteLine($"\nAverage Price: {averagePrice}");

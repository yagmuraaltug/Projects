using System;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Id = 1;
            product1.CategoryId = 2;
            product1.ProductName = "Table";
            product1.UnitPrice = 550;
            product1.UnitsInStock = 9;

            Product product2 = new Product
            {
                Id = 2, CategoryId = 2, ProductName = "Chair", UnitPrice = 300,
                UnitsInStock = 5
            };

            ProductManager productManager = new ProductManager();
            productManager.Add(product1);

        }
    }
}

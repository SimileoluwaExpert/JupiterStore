using Microsoft.EntityFrameworkCore;

namespace JupiterStore.Models
{
    public class SeedData
    {
        public static void EnsurePopulated(IApplicationBuilder app)
        {
            StoreDbContext context = app.ApplicationServices.CreateScope().ServiceProvider.GetRequiredService<StoreDbContext>();

            if (context.Database.GetPendingMigrations().Any())
            {
                context.Database.Migrate();
            }
            if (!context.Products.Any())
            {
                context.Products.AddRange(
                    new Product
                    {
                        ProductName = "Timberland Boots",
                        ProductDescription = "Winter shoe for men and women",
                        ProductCategory = "Shoes",
                        Price = 150
                    },
                    new Product
                    {
                        ProductName = "Clarks Brogues",
                        ProductDescription = "Office shoe for men and women",
                        ProductCategory = "Shoes",
                        Price = 130
                    },
                    new Product
                    {
                        ProductName = "Oriamo Smart Watch",
                        ProductDescription = "Android Smart Watch",
                        ProductCategory = "Watches",
                        Price = 70
                    },
                    new Product
                    {
                        ProductName = "Rolex",
                        ProductDescription = "Luxury Watch",
                        ProductCategory = "Watches",
                        Price = 5550
                    },
                    new Product
                    {
                        ProductName = "Thomas Pink Shirt",
                        ProductDescription = "T-Shirts for Men",
                        ProductCategory = "Shirts",
                        Price = 80
                    },
                    new Product
                    {
                        ProductName = "Zara Polo Shirt",
                        ProductDescription = "Polo Shirts for Women",
                        ProductCategory = "Shirts",
                        Price = 150
                    },
                    new Product
                    {
                        ProductName = "Lenovo ThinkPad",
                        ProductDescription = "Lenovo Laptops",
                        ProductCategory = "Computers",
                        Price = 1250
                    },
                    new Product
                    {
                        ProductName = "Apple Pro M2",
                        ProductDescription = "Apple Laptops",
                        ProductCategory = "Computers",
                        Price = 150
                    },
                    new Product
                    {
                        ProductName = "Samsung Galaxy S7",
                        ProductDescription = "Smart Phone",
                        ProductCategory = "Phones",
                        Price = 800
                    },
                    new Product
                    {
                        ProductName = "Apple IPhone 15",
                        ProductDescription = "Smart Phone",
                        ProductCategory = "Phones",
                        Price = 1800
                    }
                    );
                context.SaveChanges();
            }

         }
     }
        
    
}

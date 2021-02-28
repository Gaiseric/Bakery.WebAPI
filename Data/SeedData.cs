using System.Linq;
using Bakery.WebAPI.Models;

namespace Bakery.WebAPI.Data
{
    public static class SeedData
    {
        public static void Initialize(BakeryContext context)
        {
            if (!context.Products.Any())
            {
                context.Products.AddRange(
                    new Product
                    {
                        Id = 1,
                        Name = "Carrot Cake",
                        Description = "A scrumptious mini-carrot cake encrusted with sliced almonds",
                        Price = 8.99m,
                    },
                    new Product
                    {
                        Id = 2,
                        Name = "Lemon Tart",
                        Description = "A delicious lemon tart with fresh meringue cooked to perfection",
                        Price = 9.99m,
                    },
                    new Product
                    {
                        Id = 3,
                        Name = "Cupcakes",
                        Description = "Delectable vanilla and chocolate cupcakes",
                        Price = 5.99m,
                    },
                    new Product
                    {
                        Id = 4,
                        Name = "Bread",
                        Description = "Fresh baked French-style bread",
                        Price = 1.49m,
                    }
                );

                context.SaveChanges();
            }
        }
    }
}
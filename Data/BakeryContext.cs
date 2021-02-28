using Microsoft.EntityFrameworkCore;
using Bakery.WebAPI.Models;

namespace Bakery.WebAPI.Data
{
    public class BakeryContext: DbContext
    {
        public BakeryContext (DbContextOptions<BakeryContext> options): base(options)
        {}

        public DbSet<Product> Products { get; set; }
    }
}
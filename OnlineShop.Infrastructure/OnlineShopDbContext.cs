using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using OnlineShop.Core.Entities;

namespace OnlineShop.Infrastructure
{
    public class OnlineShopDbContext:DbContext
    {
        public OnlineShopDbContext(DbContextOptions<OnlineShopDbContext> options) : base(options) 
        {

        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Cart> Carts { get; set; }
        public DbSet<Vendor> Vendor { get; set; }
        public DbSet<Order> Order { get; set; }
        public DbSet<Customer> Customer { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}

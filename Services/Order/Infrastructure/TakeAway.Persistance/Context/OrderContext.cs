using Microsoft.EntityFrameworkCore;
using TakeAway.Domain.Entities;

namespace TakeAway.Persistance.Context
{
    public class OrderContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-P40Q2KE\\SQLEXPRESS;Initial Catalog=TakeAwayOrderDB;Integrated Security=true");
        }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Ordering> Orderings { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
    }
}

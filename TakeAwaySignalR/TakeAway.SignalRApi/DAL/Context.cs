using Microsoft.EntityFrameworkCore;

namespace TakeAway.SignalRApi.DAL
{
    public class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-P40Q2KE\\SQLEXPRESS; Initial Catalog = TakeAwaySignalRDB; Integrated Security = true");
        }
        public DbSet<Delivery> Deliveries { get; set; }
    }
}

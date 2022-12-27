using Hotel.Shared.Entites;
using Microsoft.EntityFrameworkCore;

namespace Hotel.Server.Data
{
    public class AddDbContext:DbContext
    {
        public AddDbContext(DbContextOptions<AddDbContext> options) : base(options)
        {

        }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<Resevation> Resevations { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<TravalCompany> TravalCompanies { get; set; }
    }
}

using Microsoft.EntityFrameworkCore;
using OrderProcessing.Domain.Entities;

namespace OrderProcessing.Infrastructure.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Client> Clients { get; set; }
    }
}
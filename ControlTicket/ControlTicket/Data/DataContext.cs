using ControlTicket.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace ControlTicket.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        public DbSet<Ticket> Tickets { get; set; }
        public DbSet<Entrace> Entrace { get; set; }
        public object Entraces { get; internal set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Ticket>().HasIndex(t => t.Id).IsUnique();
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Entrace>().HasIndex(e => e.Id).IsUnique();
        }

    }
}

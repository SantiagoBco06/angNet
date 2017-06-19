using Microsoft.EntityFrameworkCore;
using White.Models;

namespace White.Data
{
    public class ActorContext : DbContext
    {
        public ActorContext(DbContextOptions<ActorContext> options) : base(options)
        {
        }

        public DbSet<Actor> Actors { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Address> Addresses { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Actor>().ToTable("actor");
            modelBuilder.Entity<Actor>().HasKey(x => x.actor_id);
        
            modelBuilder.Entity<Customer>().ToTable("customer");
            modelBuilder.Entity<Customer>().HasKey(x => x.customer_id);

            modelBuilder.Entity<Address>().ToTable("address");
            modelBuilder.Entity<Address>().HasKey( x => x.address_id);
            

        }

    }
}

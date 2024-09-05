using FM.WebSite.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using NuGet.Protocol.Plugins;
using WebApplication11.Models.CustomerCare;





namespace WebApplication11.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<FridgeAllocation> FridgeAllocations { get; set; }

        public DbSet<Decision> Decisions { get; set; }
        public DbSet<ProfileRequest> profileRequests { get; set; }

        public DbSet<Fridge> Fridges { get; set; }
        public DbSet<FridgeScrap> FridgeScarps { get; set; }

        public DbSet<PurchaseRequest> PurchaseRequests { get; set; }
        public DbSet<Employee> Employee { get; set; }
        public DbSet<User> User { get; set; }
        //public DbSet<Customer> Customer { get; set; }
        public DbSet<Supplier> Supplier { get; set; }
        //public DbSet<Fridge> Fridge { get; set; }
        //public DbSet<Visit> Visit { get; set; }
        //public DbSet<Fault> Fault { get; set; }
        public DbSet<Record> Record { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);


            modelBuilder.Entity<FridgeAllocation>()
                .HasOne(f => f.Customers)
                .WithMany(c => c.FridgeAllocations)
                .HasForeignKey(f => f.CustomerId);

            modelBuilder.Entity<FridgeAllocation>()
                .HasOne(f => f.Decisions)
                .WithMany(c => c.FridgeAllocations)
                .HasForeignKey(f => f.DecisionId);

            modelBuilder.Entity<FridgeAllocation>()
               .HasOne(f => f.Fridges)
               .WithMany(c => c.FridgeAllocations)
               .HasForeignKey(f => f.FridgeId);

            modelBuilder.Entity<Customer>()
                .HasOne(f => f.ProfileRequests)
                .WithMany(c => c.Customers)
                .HasForeignKey(f => f.ProfileRequestId);

            modelBuilder.Entity<PurchaseRequest>()
                .HasOne(f => f.Fridges)
                .WithMany(c => c.PurchaseRequests)
                .HasForeignKey(f => f.FridgeId);
        }
        public DbSet<WebApplication11.Models.CustomerCare.FridgeAllocation>? FridgeAllocation { get; set; }
    }
}

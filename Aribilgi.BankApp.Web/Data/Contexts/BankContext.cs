using Aribilgi.BankApp.Web.Data.Configurations;
using Aribilgi.BankApp.Web.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace Aribilgi.BankApp.Web.Data.Contexts
{
    public class BankContext : DbContext
    {
        public DbSet<Account> Accounts { get; set; }
        public DbSet<ApplicationUser> ApplicationUsers { get; set; }
        public DbSet<Transaction> Transactions { get; set; }
        public BankContext(DbContextOptions<BankContext> options) : base(options)
        {

        }
        //override modelcreating tap tap
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new AccountConfiguration());
            modelBuilder.ApplyConfiguration(new ApplicationUserConfiguration());
            modelBuilder.ApplyConfiguration(new TransactionConfiguration());
            base.OnModelCreating(modelBuilder);
        }
    }
}

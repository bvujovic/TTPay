using Microsoft.EntityFrameworkCore;
using TTPay.Models;

namespace TTPay.Models.Data
{
    public class DataContext : DbContext
    {
        public DbSet<Susret> Susreti { get; set; } = default!;

        /// <summary></summary>
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlite("Data Source=Models/Data/ttp.db");

            //dotnet ef migrations add CreateInitial --project WebApiTaggedWorld
            // Add-Migration InitialCreate
            //dotnet ef database update
            // Update-Database
        }

        //protected override void OnModelCreating(ModelBuilder builder)
        //{
        //    base.OnModelCreating(builder);

        //    builder.Entity<User>().HasAlternateKey(c => c.Username);
        //    builder.Entity<User>().HasAlternateKey(c => c.Email);

        //    builder.Entity<User>().HasMany(u => u.OwnedTargets).WithOne(t => t.UserOwner);
        //    builder.Entity<User>().HasMany(u => u.ModifiedTargets).WithOne(t => t.UserModified);
        //    builder.Entity<User>().HasMany(u => u.AccessedTargets).WithOne(t => t.UserAccessed);

        //    builder.Entity<Member>().HasKey(it => new { it.UserId, it.GroupId });

        //    //B builder.Entity<Sharing>().HasKey(s => new { s.TargetId, s.GroupId });
        //}
    }
}

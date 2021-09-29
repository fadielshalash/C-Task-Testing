using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Internship.Moudels
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<User>(entity =>
            //{
            //    entity.HasMany<Post>().WithOne(p => p.user)
            //   .HasForeignKey(p => p.UserId)
            //   .OnDelete(DeleteBehavior.Restrict);
            //});
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Post> Posts { get; set; }
    }
}

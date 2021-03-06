using System;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace SkoAppBlazorServer
{
    public class SkoContext : DbContext
    {
        public SkoContext()
        {
        }

        public SkoContext(DbContextOptions<SkoContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Course> Courses { get; set; }
        public virtual DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=172.16.0.22;Database=SOKO;User Id=Sko;Password=Sko123;");

                //Server=172.16.0.22;Database=SOKO;User Id=Sko;Password=Sko123;
                //Server=VANHOME;Database=SOKO;Trusted_Connection=True;

            }
        }
    }
}

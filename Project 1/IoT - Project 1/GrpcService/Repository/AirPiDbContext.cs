using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace GrpcService.Repository
{
    public class AirPiDbContext : DbContext
    {
        public DbSet<AirPiValue> AirPiValues{ get; set; } = null!;

        public AirPiDbContext()
        {
            
        }

        public AirPiDbContext(DbContextOptions<AirPiDbContext> options) 
            : base()
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-5TIK6BK\\SQLEXPRESS;Database=AirPiDBTest;Trusted_Connection=True;TrustServerCertificate=True");
        }

    }
}

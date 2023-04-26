using Microsoft.EntityFrameworkCore;
using VillaApi.Models;

namespace VillaApi
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {

        }
        public DbSet<Villa> Villas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Villa>().HasData(
                new Villa()
                {
                    Id = 1,
                    Name = "Royal Villa",
                    
                    Occupancy = 8,
                    
                    Sqft = 1000,
                   

                },
                new Villa
                {
                    Id = 2,
                    Name = "killa Villa",
                   
                    Occupancy = 9,
                    
                    Sqft = 2000,
                    

                },
            new Villa
            {
                Id = 3,
                Name = "Raja Villa",
               
                Occupancy = 7,
                
                Sqft = 5000,
                


            });
        }
    }
}

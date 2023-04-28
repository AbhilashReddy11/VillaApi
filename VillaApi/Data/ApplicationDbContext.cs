using Microsoft.EntityFrameworkCore;
using VillaApi.Models;

namespace VillaApi.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
          : base(options)
        {

        }
        public DbSet<Villa> Villas { get; set; }
        public DbSet<VillaNumber> VillaNumbers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Villa>().HasData(
                new Villa()
                {
                    Id = 1,
                    Name = "Royal Villa",
                    Details = " It has 2 Pool and 8 Rooms",
                    ImageUrl = "",
                    Occupancy = 8,
                    Rate = 200,
                    Sqft = 1000,
                    Amenity = "",
                    CreatedDate = DateTime.Now

                },
                new Villa
                {
                    Id = 2,
                    Name = "killa Villa",
                    Details = " It has 2 Pool and 9 Rooms",
                    ImageUrl = "",
                    Occupancy = 9,
                    Rate = 500,
                    Sqft = 2000,
                    Amenity = "",
                    CreatedDate = DateTime.Now

                },
            new Villa
            {
                Id = 3,
                Name = "Raja Villa",
                Details = " It has 2 Pool and 7 Rooms",
                ImageUrl = "",
                Occupancy = 7,
                Rate = 900,
                Sqft = 5000,
                Amenity = "",
                CreatedDate = DateTime.Now


            });
        }
    }
}

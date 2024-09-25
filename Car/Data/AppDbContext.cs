using Car.Entities;
using Microsoft.EntityFrameworkCore;

namespace Car.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

    public virtual DbSet<Cars> Carss { get; set; }


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Cars>().HasData(
            new Cars
            {
                Id = 1,
                Manufacturer = "Chevrolet",
                Model = "Cobalt",
                Color = "White",
                Price = 10000
            },
        new Cars
        {
            Id = 2,
            Manufacturer = "Chevrolet",
            Model = "Malibu",
            Color = "Black",
            Price = 15000
        },
        new Cars
        {
            Id = 3,
            Manufacturer = "Toyota",
            Model = "Camry",
            Color = "Green",
            Price = 12000
        },
        new Cars
        {
            Id = 4,
            Manufacturer = "Honda",
            Model = "Civic",
            Color = "Red",
            Price = 8000
        },
        new Cars
        {
            Id = 5,
            Manufacturer = "Ford",
            Model = "Focus",
            Color = "Yellow",
            Price = 7000
        },
        new Cars
        {
            Id = 6,
            Manufacturer = "BMW",
            Model = "X5",
            Color = "Black",
            Price = 20000
        },
        new Cars
        {
            Id = 7,
            Manufacturer = "Audi",
            Model = "A4",
            Color = "Blue",
            Price = 9000
        },
        new Cars
        {
            Id = 8,
            Manufacturer = "Mercedes",
            Model = "C-Class",
            Color = "Black",
            Price = 18000
        },
        new Cars
        {
            Id = 9,
            Manufacturer = "Hyundai",
            Model = "Elantra",
            Color = "White",
            Price = 11000
        },
        new Cars
        {
            Id = 10,
            Manufacturer = "Kia",
            Model = "Optima",
            Color = "Green",
            Price = 6000
        }

        );
    }
}

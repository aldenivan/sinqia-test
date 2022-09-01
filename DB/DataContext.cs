using Microsoft.EntityFrameworkCore;
using SinqiaTest.Model;

namespace SinqiaTest.DB
{
    public class DataContext:DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source = PlaceData.db");
        }

        public DbSet<Place> Places { get; set; }

    }
}

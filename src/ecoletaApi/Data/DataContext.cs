using ecoletaApi.Models;
using Microsoft.EntityFrameworkCore;

namespace ecoletaApi.Data 
{
  public class DataContext : DbContext
  {
    public DataContext(DbContextOptions<DataContext> options)
      : base(options)
    {
    }

    public DbSet<Item> Items { get; set; }
    public DbSet<Point> Points { get; set; }
  }
}
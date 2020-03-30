using Microsoft.EntityFrameworkCore;

namespace TravelRating.Models
{
  public class TravelRatingContext : DbContext
  {
    public TravelRatingContext(DbContextOptions<TravelRatingContext> options)
      :base(options)
      {

      }

    public DbSet<Location> Locations { get; set; }
    public DbSet<Experience> Experiences { get; set; }
  }
}
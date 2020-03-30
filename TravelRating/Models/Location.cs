namespace TravelRating.Models
{
  public class Location
  {
    public Location()
    {
      this.Experiences = new HashSet<Experience>();
    }

    public int LocationId { get; set; }
    public string Name { get; set; }
    public string City { get; set; }
    public string Country { get; set; }
    public virtual ICollection<Experience> Experiences { get; set; }
  }
}
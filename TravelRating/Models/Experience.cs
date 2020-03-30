namespace TravelRating.Models
{
  public class Experience
  {
    public int ExperienceId { get; set; }
    public string Author { get; set; }
    public string Review { get; set; }
    public int Rating { get; set; }
    public int LocationId { get; set; }
  }
}
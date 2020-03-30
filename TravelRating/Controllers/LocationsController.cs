using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TravelRating.Models;


namespace TravelRating.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class LocationsController : ControllerBase
  {
    private TravelRatingContext _db;

    public LocationsController(TravelRatingContext db)
    {
      _db = db;
    }

    [HttpGet]
    public ActionResult<IEnumerable<Location>> Get()
    {
      return _db.Locations.ToList();
    }

     [HttpPost]
     public void Post([FromBody] Location location)
     {
       _db.Locations.Add(location);
       _db.SaveChanges();
     }

     [HttpGet("{id}")]
     public ActionResult<Location> GetAction(int id)
     {
       return _db.Locations.FirstOrDefault(entry => entry.LocationId == id);
     }


  }
}
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CityInfo.API.Controllers
{
    [Route("api/cities")]
    public class PointsOfInterestController : Controller 
    {
        [HttpGet("{cityId}/pointsofinterest")]
        public IActionResult GetPointsOfInterest (int cityId)
        {
            var city = CitiesDataStore.Current.Cities.FirstOrDefault(c => c.Id == cityId);

            if (city == null)
            {
                return NotFound();
            }

            return Ok(city.PointsOfInterest);
        }

        [HttpGet("{cityId}/pointsofinterest/{interestId}")]
        public IActionResult GetPointOfInterest(int cityId, int interestId)
        {
            var city = CitiesDataStore.Current.Cities.FirstOrDefault(c => c.Id == cityId);

            if (city == null)
            {
                return NotFound();
            }
            var interest = city.PointsOfInterest.FirstOrDefault(c => c.Id == interestId);

            if (city == null)
            {
                return NotFound();
            }

            return Ok(interest);
        }
    }
}

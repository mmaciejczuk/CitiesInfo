using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CityInfo.API.Models;

namespace CityInfo.API
{
    public class CitiesDataStore
    { 
        // nowość w c# 6
        // CitiesDataStore.Current.Cities
        public static CitiesDataStore Current { get; } = new CitiesDataStore();
        public List<CityDto> Cities { get; set; }

        public CitiesDataStore()
        {
            // init dummy data
            Cities = new List<CityDto>()
            {
                new CityDto()
                {
                    Id = 1,
                    Name = "New York City",
                    Description = "The one with the big park",
                    PointsOfInterest = new List<PointOfInterestDto>()
                    {
                        new PointOfInterestDto()
                        {
                            Id = 1,
                            Name = "Central Park",
                            Description = "bla bla"
                        },
                        new PointOfInterestDto()
                        {
                            Id = 2,
                            Name = "Central Park",
                            Description = "bla bla"
                        }
                    }
                },
                new CityDto()
                {
                    Id = 2,
                    Name = "Antwerp",
                    Description = "The one with the two towers",
                    PointsOfInterest = new List<PointOfInterestDto>()
                    {
                        new PointOfInterestDto()
                        {
                            Id = 1,
                            Name = "Central Park",
                            Description = "bla bla"
                        },
                        new PointOfInterestDto()
                        {
                            Id = 2,
                            Name = "Central Park",
                            Description = "bla bla"
                        }
                    }
                },
                new CityDto()
                {
                    Id = 3,
                    Name = "Paris",
                    Description = "The one with the big park",
                    PointsOfInterest = new List<PointOfInterestDto>()
                    {
                        new PointOfInterestDto()
                        {
                            Id = 1,
                            Name = "Central Park",
                            Description = "bla bla"
                        },
                        new PointOfInterestDto()
                        {
                            Id = 2,
                            Name = "Central Park",
                            Description = "bla bla"
                        }
                    }
                }
            };
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TheWorld.Models
{
    public class WorldContextSeedData
    {
        private WorldContext _context;

        public WorldContextSeedData(WorldContext context)
        {
            _context = context;
        }

        public void EnsureSeedDate()
        {
            if (!_context.Trips.Any())
            {
                //Add new data
                var usTrip = new Trip()
                {
                    Name = "US Trip",
                    Created = DateTime.UtcNow,
                    UserName = "",
                    Stops = new List<Stop>() {
                        new Stop() { Name = "Atlanta, GA", Arrival = new DateTime(2014,6,4), Latitude=33.748995,Longitude=-84.387982, Order = 0 },
                        new Stop() { Name = "New York, NY", Arrival = new DateTime(2014,6,9), Latitude=40.712784,Longitude=-74.005941, Order = 1 },
                        new Stop() { Name = "Boston, MA", Arrival = new DateTime(2014,7,1), Latitude=42.360082,Longitude=-71.058880, Order = 2 },
                        new Stop() { Name = "Chicago, IL", Arrival = new DateTime(2014,7,10), Latitude=41.878114,Longitude=-87.629798, Order = 3 },
                        new Stop() { Name = "Seattle, WA", Arrival = new DateTime(2014,8,13),  Latitude=47.606209,Longitude=-122.332071, Order = 4 },
                        new Stop() { Name = "Atlanta, GA", Arrival = new DateTime(2014,8,23),  Latitude=33.748995,Longitude=-84.387982, Order = 5 }
                    }
                };

                //var worldTrip = new Trip()
                //{
                //    Name = "World Trip",
                //    Created = DateTime.UtcNow,
                //    UserName = "",
                //    Stops = new List<Stop>() { }
                //};

                _context.Trips.Add(usTrip);
                _context.Stops.AddRange(usTrip.Stops);
                _context.SaveChanges();
            }
        }
    }
}

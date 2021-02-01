using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class FlightService
    {
        private AirlinesDbContext _context;
        public FlightService()
        {
            _context = new AirlinesDbContext();
        }

        // TODO: Write methods for find flights
        public IQueryable<Flight> GetAllFlights()
        {
            return _context.Flights;
        }
        public void FindFlights(DateTime date, string place)
        {
            throw new NotImplementedException();
        }
    }
}

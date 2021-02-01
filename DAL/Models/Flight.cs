using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class Flight
    {
        [Key]
        public int Number { get; set; }
        public DateTime DepartureTime { get; set; }

        // FOREIGN KEYS
        public int AirplaneId { get; set; }
        public int CityFromId { get; set; }
        public int CityToId { get; set; }

        // NAVIGATION PROPERTIES
        public virtual City CityFrom { get; set; }
        public virtual City CityTo { get; set; }
        public virtual Airplane Airplane { get; set; }
        public virtual ICollection<Client> Clients { get; set; }
    }
}

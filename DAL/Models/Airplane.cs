using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class Airplane
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(100)]
        public string Model { get; set; }
        public int MaxPassengers { get; set; }

        // FOREIGN KEYS
        public int TypeId { get; set; }
        public int? CountryId { get; set; }

        // NAVIGATION PROPERTIES
        public virtual Country Country { get; set; }
        public virtual Type Type { get; set; }
        public virtual ICollection<Flight> Flights { get; set; }
    }
}

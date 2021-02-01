using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class City
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(100)]
        public string Name { get; set; }

        // FOREIGN KEYS
        public int CountryId { get; set; }

        // NAVIGATION PROPERTIES
        public virtual Country Country { get; set; }
        public virtual ICollection<Flight> FlightsTo { get; set; }
        public virtual ICollection<Flight> FlightsFrom { get; set; }
    }
}

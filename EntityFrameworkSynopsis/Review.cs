using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkSynopsis
{
    class Review
    {
        [Key]
        [Column(Order = 0)]
        [ForeignKey("Airline")]
        public string AirlineId { get; set; }
        [Key]
        [Column(Order = 1)]
        [ForeignKey("Person")]
        public int PersonId { get; set; }
        public Destination Destination { get; set; }
        public string Comment { get; set; }

        public virtual Airline Airline { get; set; }
        public virtual Person Person { get; set; }
    }
}

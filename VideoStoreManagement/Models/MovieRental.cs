using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace VideoStoreManagement.Models
{
    public class MovieRental
    {
        public int Id { get; set; }

        [Required]
        public DateTime DateIsued { get; set; }
        [Required]
        public DateTime DateReterned { get; set; }
        [Required]
        public bool IsMovieLateReturned { get; set; }

        [ForeignKey("MovieFK")]
        public Movie movie { get; set; }
        public int MovieFK { get; set; }

        [ForeignKey("CustomerFK")]
        public Customer customer { get; set; }
        public int CustomerFK { get; set; }
    }
}

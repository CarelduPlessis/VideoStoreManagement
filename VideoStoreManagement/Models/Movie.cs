using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace VideoStoreManagement.Models
{
    public class Movie
    {
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }
        [Required]
        public DateTime Release { get; set; }
        [Required]
        public int Copies { get; set; }
        [Required]
        public decimal Cost { get; set; }
    }
}

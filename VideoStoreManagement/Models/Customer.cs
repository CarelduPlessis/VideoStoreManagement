using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace VideoStoreManagement.Models
{
    public class Customer
    {
        public int Id { get; set; }

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        //[HiddenInput(DisplayValue = true)]
        public string FullName
        {
            get { return FirstName + " " + LastName; }
        }

        [Required]
        public string Address { get; set; }
        [Required]
        public string Phone { get; set; }
    }
}

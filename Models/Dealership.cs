using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Lab1B.Models
{
    public class Dealership
    {
        [Key]   
        public int ID { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Email { get; set; }


        public int PhoneNumer { get; set; }
    }
}

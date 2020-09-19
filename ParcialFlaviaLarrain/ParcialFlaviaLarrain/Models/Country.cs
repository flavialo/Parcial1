using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ParcialFlaviaLarrain.Models
{
    public class Country
    {
        [Key]
        [Required]
        [StringLength(3, ErrorMessage = "nombre no valido", MinimumLength = 3)]
        public string alpha3Code { get; set; }
        [Required]
        public string region { get; set; }
       
        [Required]
        public string name { get; set; }
        [Required]
        [Range(1, 5000000000)]
        public int area { get; set; }
        [Required]
        [Range(1, 1000)]
        public int callingCodes { get; set; }
        [Required]
        public List<lang> languages { get; set; }
        [Required]
        public string Flag { get; set; }

    }
    public class lang
    {
        [Key]
        [Required]
        [StringLength(2, ErrorMessage = "Nombre no valido", MinimumLength = 2)]
        public string iso639_1 { get; set; }
        
        [Required]
        [StringLength(3, ErrorMessage = "Nombre no valido", MinimumLength = 3)]
        public string iso639_2 { get; set; }
        [Required]
        public string name { get; set; }
        [Required]
        public string nativeName { get; set; }

    }

}
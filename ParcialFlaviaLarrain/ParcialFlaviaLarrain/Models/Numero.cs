using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ParcialFlaviaLarrain.Models
{
    public class Numero
    {
        [Key]
        [Required]
        [Range(1, 5000000000, ErrorMessage = "Error" )]
        

        public int numero { get; set; }
        
        





    }


}


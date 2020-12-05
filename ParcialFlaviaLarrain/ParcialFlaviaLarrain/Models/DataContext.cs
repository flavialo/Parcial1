using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using ParcialFlaviaLarrain.Controllers;

namespace PracticaParcial.Models
{
    public class DataContext : DbContext
    {
        public DataContext() : base("DefaultConnection")
        {

        }

        public System.Data.Entity.DbSet<ParcialFlaviaLarrain.Models.Numero> Numeroes { get; set; }
    }
}

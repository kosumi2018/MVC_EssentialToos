using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_EssentialToos.Models
{
    public class Product
    {
        public int ProductID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Peice { get; set; }
        public string Category { get; set; }
    }
}
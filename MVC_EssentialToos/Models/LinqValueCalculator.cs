﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_EssentialToos.Models
{
    public class LinqValueCalculator : IValueCalculator
    {
        public decimal ValueProducts(IEnumerable<Product> products)
        {
            return products.Sum(p => p.Peice);
        }
    }
}
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ASPMVCShoppingCart.Models
{
    public class ClProduct
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }

    }
}
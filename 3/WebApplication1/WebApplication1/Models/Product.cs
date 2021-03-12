using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class Product
    {
        //( Product_id, Product_name, Product_description)
        public int Product_id { get; set; }
        public String Product_name { get; set; }
        public String Product_description { get; set; }
    }
}
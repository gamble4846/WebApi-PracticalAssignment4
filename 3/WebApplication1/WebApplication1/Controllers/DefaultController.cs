using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    [RoutePrefix("api/products")]
    public class DefaultController : ApiController
    {
        static List<Product> Products = new List<Product>();

        [Route("Add")]
        [HttpPost]
        public String addProduct(String Product_name, String Product_description)
        {
            Product obj = new Product();
            obj.Product_name = Product_name;
            obj.Product_description = Product_description;
            obj.Product_id = Products.Count == 0 ? 0 : (Products[Products.Count - 1].Product_id + 1);
            Products.Add(obj);
            return "Product Added";
        }

        [Route("View")]
        [HttpGet]
        public List<Product> viewProducts()
        {
            return Products;
        }

        [Route("Delete/{Product_ID}")]
        [HttpPost]
        public String deleteProduct(int Product_id)
        {
            String Product_Name = "";
            String returnstring;
            bool flag = false;

            for (int i = 0; i < Products.Count; i++)
            {
                if (Products[i].Product_id == Product_id)
                {
                    Product_Name = Products[i].Product_name;
                    Products.RemoveAt(i);
                    flag = true;
                }
            }

            returnstring = (flag) ? Product_Name + " Is Deleted" : "Product Not Found";

            return returnstring;
        }

        [Route("Update")]
        [HttpPost]
        public String updateMovie(int Product_id, String Product_name, String Product_description)
        {
            String Product_Name = "";
            String returnstring;
            bool flag = false;

            for (int i = 0; i < Products.Count; i++)
            {
                if (Products[i].Product_id == Product_id)
                {
                    Product_Name = Products[i].Product_name = Product_name;
                    Products[i].Product_description = Product_description;
                    flag = true;
                }
            }

            returnstring = (flag) ? Product_Name + " Is Updated" : "Movie Not Found";
            return returnstring;
        }
    }
}  

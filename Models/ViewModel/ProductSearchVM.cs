using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _24DH110161_LTW.Models.ViewModel
{
    public class ProductSearchVM
    {
        public string SearchTerm { get; set; }
        public List<Product> Products { get; set; }
        public decimal MinPrice { get; set; }

        public decimal MaxPrice { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _24DH110161_LTW.Models.ViewModel
{
    public class ProductDetailsVM
    {
        public Product product { get; set; }
        public int quantity { get; set; }

        public decimal estimatedValue { get; set; } /*= quantity * Product.ProductPrice;*/
        public int PageNumber { get; set; }

        public int PageSize { get; set; } = 3;

        public List<Product> RelatedProducts { get; set; }

        public PagedList.IPagedList<Product> TopProducts { get; set; }
    }
}
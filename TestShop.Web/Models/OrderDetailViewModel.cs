using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TestShop.Web.Models
{
    public class OrderDetailViewModel
    {
        public int OrderID { set; get; }
        public virtual OrderViewModel Order { set; get; }
        public int ProductID { set; get; }
        public virtual ProductViewModel Product { set; get; }
        public int Quanlity { set; get; }
    }
}
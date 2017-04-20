using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TestShop.Web.Models
{
    public class TagViewModel
    {
        public string ID { set; get; }
        public string Name { set; get; }  
        public string Type { set; get; }
        public virtual IEnumerable<ProductTagViewModel> TagProducts { set; get; }
        public virtual IEnumerable<PostTagViewModel> TagPosts { set; get; }
    }
}
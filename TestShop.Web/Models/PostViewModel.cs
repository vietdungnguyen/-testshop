using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TestShop.Web.Models
{
    public class PostViewModel
    {
        public int ID { set; get; }
        public string Name { set; get; }
        public string Alias { set; get; }
        public int CategoryID { set; get; }
        public virtual PostCategoryViewModel post { set; get; }
        public string Image { set; get; }  
        public string Description { set; get; }
        public string Content { set; get; }
        public bool? HomeFlag { set; get; }
        public bool? HotFlag { set; get; }
        public int ViewCount { set; get; }
        public virtual IEnumerable<PostTagViewModel> PostTags { set; get; }
        public DateTime? CreatedDate { set; get; }
        public string CretedBy { set; get; }
        public DateTime? UpdatedDate { set; get; }
        public string UpdateBy { set; get; }
        public string MetaKeyword { set; get; }
        public string MetaDiscription { set; get; }
        public bool status { set; get; }
    }
}
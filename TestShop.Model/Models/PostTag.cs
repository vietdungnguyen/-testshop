using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TestShop.Model.Models
{
    [Table("PostTags")]
    public class PostTag
    {
        [Key]
        public int PostID { set; get; }
        [ForeignKey("PostID")]
        public virtual Post Post { set; get; }
        [Key]
        public string TagID { set; get; }
        [ForeignKey("TagID")]
        public virtual Tag Tag { set; get; }
    }
}
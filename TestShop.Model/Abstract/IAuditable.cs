using System;

namespace TestShop.Model.Abstract
{
    public interface IAuditable
    {
        DateTime? CreatedDate { set; get; }
        string CretedBy { set; get; }
        DateTime? UpdatedDate { set; get; }
        string UpdateBy { set; get; }
        string MetaKeyword { set; get; }
        string MetaDiscription { set; get; }
        bool status { set; get; }
    }
}
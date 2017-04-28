using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TestShop.Model.Models;
using TestShop.Web.Models;

namespace TestShop.Web.Infrastructure.Extensions
{
    public static class EntityExtensions
    {
        public static void UpdatePostCategory(this PostCategory postCategory, PostCategoryViewModel postCategoryViewModel)
        {
            postCategory.ID = postCategoryViewModel.ID;
            postCategory.Name = postCategoryViewModel.Name;
            postCategory.Alias = postCategoryViewModel.Alias;
            postCategory.Description = postCategoryViewModel.Description;
            postCategory.ParentID = postCategoryViewModel.ParentID;
            postCategory.DisplayOrder = postCategoryViewModel.DisplayOrder;
            postCategory.Image = postCategoryViewModel.Image;
            postCategory.HomeFlag = postCategoryViewModel.HomeFlag;
            postCategory.CreatedDate = postCategoryViewModel.CreatedDate;
            postCategory.CretedBy = postCategoryViewModel.CretedBy;
            postCategory.UpdateBy = postCategoryViewModel.UpdateBy;
            postCategory.UpdatedDate = postCategoryViewModel.UpdatedDate;
            postCategory.MetaKeyword = postCategoryViewModel.MetaKeyword;
            postCategory.MetaDiscription = postCategoryViewModel.MetaDiscription;
            postCategory.status = postCategoryViewModel.status;


        }

        public static void UpdatePost(this Post post, PostViewModel postViewModel)
        {
            post.ID = postViewModel.ID;
            post.Name = postViewModel.Name;
            post.Alias = postViewModel.Alias;
            post.Description = postViewModel.Description;         
            post.CategoryID = postViewModel.CategoryID;
            post.Image = postViewModel.Image;
            post.Content = postViewModel.Content;
            post.HomeFlag = postViewModel.HomeFlag;
            post.HotFlag = postViewModel.HotFlag;
            post.ViewCount = postViewModel.ViewCount;
            post.Tags = postViewModel.Tags;
            post.CreatedDate = postViewModel.CreatedDate;
            post.CretedBy = postViewModel.CretedBy;
            post.UpdateBy = postViewModel.UpdateBy;
            post.UpdatedDate = postViewModel.UpdatedDate;
            post.MetaKeyword = postViewModel.MetaKeyword;
            post.MetaDiscription = postViewModel.MetaDiscription;
            post.status = postViewModel.status;
        }

        public static void UpdateProductCategory(this ProductCategory productCategory, ProductCategoryViewModel productCategoryViewModel)
        {
           productCategory.ID = productCategoryViewModel.ID;
           productCategory.Name = productCategoryViewModel.Name;
           productCategory.Alias = productCategoryViewModel.Alias;
           productCategory.Description = productCategoryViewModel.Description;
           productCategory.ParentID = productCategoryViewModel.ParentID;
           productCategory.DisplayOrder = productCategoryViewModel.DisplayOrder;
           productCategory.Image = productCategoryViewModel.Image;
           productCategory.HomeFlag = productCategoryViewModel.HomeFlag;
           productCategory.CreatedDate = productCategoryViewModel.CreatedDate;
           productCategory.CretedBy = productCategoryViewModel.CretedBy;
           productCategory.UpdateBy = productCategoryViewModel.UpdateBy;
           productCategory.UpdatedDate = productCategoryViewModel.UpdatedDate;
           productCategory.MetaKeyword = productCategoryViewModel.MetaKeyword;
           productCategory.MetaDiscription = productCategoryViewModel.MetaDiscription;
           productCategory.status = productCategoryViewModel.status;


        }

        public static void UpdateProduct(this Product product, ProductViewModel productViewModel)
        {
           product.ID = productViewModel.ID;
           product.Name = productViewModel.Name;
           product.Alias = productViewModel.Alias;
           product.Description = productViewModel.Description;
           product.CategoryID = productViewModel.CategoryID;
           product.MoreImages = productViewModel.MoreImages;
           product.Price = productViewModel.Price;
           product.PromotionPrice = productViewModel.PromotionPrice;
           product.Warranty = productViewModel.Warranty;
           product.Image = productViewModel.Image;
           product.Content = productViewModel.Content;
           product.HomeFlag = productViewModel.HomeFlag;
           product.HotFlag = productViewModel.HotFlag;
           product.ViewCount = productViewModel.ViewCount;
           product.Tags = productViewModel.Tags;
            product.CreatedDate = productViewModel.CreatedDate;
           product.CretedBy = productViewModel.CretedBy;
           product.UpdateBy = productViewModel.UpdateBy;
           product.UpdatedDate = productViewModel.UpdatedDate;
           product.MetaKeyword = productViewModel.MetaKeyword;
           product.MetaDiscription = productViewModel.MetaDiscription;
           product.status = productViewModel.status;
        }
    }
}
﻿using System;
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
            post.CreatedDate = postViewModel.CreatedDate;
            post.CretedBy = postViewModel.CretedBy;
            post.UpdateBy = postViewModel.UpdateBy;
            post.UpdatedDate = postViewModel.UpdatedDate;
            post.MetaKeyword = postViewModel.MetaKeyword;
            post.MetaDiscription = postViewModel.MetaDiscription;
            post.status = postViewModel.status;
        }
    }
}
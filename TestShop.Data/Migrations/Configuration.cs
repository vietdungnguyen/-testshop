namespace TestShop.Data.Migrations
{
    using Common;
    using Data;
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;
    using Model.Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<TestShop.Data.TestShopDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(TestShop.Data.TestShopDbContext context)
        {
            // create sample product category
            // CreateProductCategorySample(context);


            // create sample post category
           // CreatePostCategorySample(context);

            //  This method will be called after migrating to the latest version.

            //var manager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(new TestShopDbContext()));

            //var roleManager = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(new TestShopDbContext()));

            //var user = new ApplicationUser()
            //{
            //    UserName ="admin",
            //    Email="vietdungnguyen194@gmail.com",
            //    EmailConfirmed=true,
            //    Birthday=DateTime.Now,
            //    FullName="Nguyen Viet Dung"

            //};
            //manager.Create(user, "123456");
            //if(!roleManager.Roles.Any())
            //{
            //    roleManager.Create(new IdentityRole { Name="Admin" });
            //    roleManager.Create(new IdentityRole { Name = "User" });
            //}
            //var adminUser = manager.FindByEmail("vietdungnguyen194@gmail.com");

            //manager.AddToRole(adminUser.Id, "Admin");

        }
        private void CreateProductCategorySample(TestShop.Data.TestShopDbContext context)
        {
            if (context.ProductCategories.Count() == 0)
            {
                List<ProductCategory> listProductCategory = new List<ProductCategory>()
            {
                new ProductCategory() {Name="Danh muc 1",Alias="danh-muc-1",status=true },
                new ProductCategory() {Name="Danh muc 2",Alias="danh-muc-2",status=true },
                new ProductCategory() {Name="Danh muc 3",Alias="danh-muc-3",status=true },
                new ProductCategory() {Name="Danh muc 4",Alias="danh-muc-4",status=true },
            };
                context.ProductCategories.AddRange(listProductCategory);
                context.SaveChanges();
            }          
        }

        private void CreatePostCategorySample(TestShop.Data.TestShopDbContext context)
        {
            if (context.PostCategories.Count() == 0)
            {
                List<PostCategory> listPostCategory = new List<PostCategory>()
            {
                new PostCategory() {Name="Danh muc tin tuc 1",Alias="danh-muc-tin-tuc-1",status=true },
                new PostCategory() {Name="Danh muc tin tuc 2",Alias="danh-muc-tin-tuc-2",status=true },
                new PostCategory() {Name="Danh muc tin tuc 3",Alias="danh-muc-tin-tuc-3",status=true },
                new PostCategory() {Name="Danh muc tin tuc 4",Alias="danh-muc-tin-tuc-4",status=true },
            };
                context.PostCategories.AddRange(listPostCategory);
                context.SaveChanges();
            }
        }
        private void CreateFooter(TestShop.Data.TestShopDbContext context)
        {
            if (context.Footers.Count(x=>x.ID==CommonConstants.DefaultFooterId) == 0)
            {
                string content = "";
            }
        }
    }
}

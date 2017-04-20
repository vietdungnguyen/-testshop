namespace TestShop.Data.Migrations
{
    using Data;
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;
    using Model.Models;
    using System;
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
            //  This method will be called after migrating to the latest version.

            var manager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(new TestShopDbContext()));

            var roleManager = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(new TestShopDbContext()));

            var user = new ApplicationUser()
            {
                UserName ="admin",
                Email="vietdungnguyen194@gmail.com",
                EmailConfirmed=true,
                Birthday=DateTime.Now,
                FullName="Nguyen Viet Dung"
                
            };
            manager.Create(user, "123456");
            if(!roleManager.Roles.Any())
            {
                roleManager.Create(new IdentityRole { Name="Admin" });
                roleManager.Create(new IdentityRole { Name = "User" });
            }
            var adminUser = manager.FindByEmail("vietdungnguyen194@gmail.com");

            manager.AddToRole(adminUser.Id, "Admin");
            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
        }
    }
}

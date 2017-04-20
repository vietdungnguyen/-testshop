using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using TestShop.Data.Infrastructure;
using TestShop.Data.Reponsitories;
using TestShop.Model.Models;

namespace TestShop.UnitTest.ReponsitoryTest
{
    [TestClass]
    public class PostCategoryReponsitoryTest
    {
        IDbFactory dbFactory;
        IPostCategoryReponsitory objReponsitory;
        IUnitOfWork unitOfWork;
        [TestInitialize]
        public void Initialize()
        {
            dbFactory = new DbFactory();
            objReponsitory = new PostCategoryReponsitory(dbFactory);
            unitOfWork = new UnitOfWork(dbFactory);
        }
        [TestMethod]
        public void PostCategory_Reponsitory_GetAll()
        {
            var list = objReponsitory.GetAll().ToList();
            Assert.AreEqual(1, list.Count);
        }
        [TestMethod]
       public void PostCategory_Reponsitory_Create()
        {
            PostCategory category = new PostCategory();
            category.Name = "Test category";
            category.Alias = "Test-category";
            category.status = true;

            var result = objReponsitory.Add(category);
            unitOfWork.Comid();

            Assert.IsNotNull(result);
            Assert.AreEqual(1,result.ID);

        }
    }
}
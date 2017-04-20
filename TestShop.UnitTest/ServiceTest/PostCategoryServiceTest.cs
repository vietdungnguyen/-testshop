using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System.Collections.Generic;
using TestShop.Data.Infrastructure;
using TestShop.Data.Reponsitories;
using TestShop.Model.Models;
using TestShop.Service;

namespace TestShop.UnitTest.ServiceTest
{
    [TestClass]
    public class PostCategoryServiceTest
    {
        private Mock<IPostCategoryReponsitory> _mockReponsitory;
        private Mock<IUnitOfWork> _mockUnitOfWork;
        private IPostCategoryService _postCategoryService;
        private List<PostCategory> _listCategory;
        [TestInitialize]

        public void Initialize()
        {
            _mockReponsitory = new Mock<IPostCategoryReponsitory>();
            _mockUnitOfWork = new Mock<IUnitOfWork>();
            _postCategoryService = new PostCategoryService(_mockReponsitory.Object, _mockUnitOfWork.Object);
            _listCategory = new List<PostCategory>()
            {
                new PostCategory() {ID=1, Name="DM1",status=true },
                new PostCategory() {ID=2, Name="DM2",status=true },
                new PostCategory() {ID=3, Name="DM3",status=true }
            };
        }

        [TestMethod]
        public void PostCategory_Service_GetAll()
        {
            //setup method
            _mockReponsitory.Setup(m => m.GetAll(null)).Returns(_listCategory);

            //call action
            var result = _postCategoryService.GetAll() as List<PostCategory>;

            //compare
            Assert.IsNotNull(result);
            Assert.AreEqual(3, result.Count);

        }

        [TestMethod]
        public void PostCaegory_Service_Create()
        {
            int id = 1;
            PostCategory category = new PostCategory();
            category.Name = "Test";
            category.Alias = "Test";
            category.status = true;

            _mockReponsitory.Setup(m => m.Add(category)).Returns((PostCategory p) =>
            {
                p.ID = 1;
                return p;
            });
            var result = _postCategoryService.Add(category);

            Assert.IsNotNull(result);
            Assert.AreEqual(1, result.ID);
        }
    }
}
using System;
using System.Collections.Generic;
using TestShop.Data.Infrastructure;
using TestShop.Data.Reponsitories;
using TestShop.Model.Models;

namespace TestShop.Service
{
    public interface IProductCategoryService
    {
        ProductCategory Add(ProductCategory productCategory);

        void Update(ProductCategory productCategory);

        ProductCategory Delete(int id);

        IEnumerable<ProductCategory> GetAll();

        IEnumerable<ProductCategory> GetAll(string keyword);

        IEnumerable<ProductCategory> GetAllByParentId(int parentId);

        ProductCategory GetById(int id);

        void Save();
    }

    public class ProductCategoryService : IProductCategoryService
    {
        private IProductCategoryRepository _productCategoryReponsitory;
        private IUnitOfWork _unitOfWork;

        public ProductCategoryService(IProductCategoryRepository productCategoryReponsitory, IUnitOfWork unitOfWork)
        {
            this._productCategoryReponsitory = productCategoryReponsitory;
            this._unitOfWork = unitOfWork;
        }

        public ProductCategory Add(ProductCategory productCategory)
        {
            return _productCategoryReponsitory.Add(productCategory);
        }

        public ProductCategory Delete(int id)
        {
            return _productCategoryReponsitory.Delete(id);
        }

        public IEnumerable<ProductCategory> GetAll()
        {
            return _productCategoryReponsitory.GetAll();
        }

        public IEnumerable<ProductCategory> GetAll(string keyword)
        {
            if (!string.IsNullOrEmpty(keyword))
            {
                return _productCategoryReponsitory.GetMulti(x => x.Name.Contains(keyword) || x.Description.Contains(keyword));
            }
            else
                return _productCategoryReponsitory.GetAll();


        }

        public IEnumerable<ProductCategory> GetAllByParentId(int parentId)
        {
            return _productCategoryReponsitory.GetMulti(x => x.status && x.ParentID == parentId);
        }

        public ProductCategory GetById(int id)
        {
            return _productCategoryReponsitory.GetSingleById(id);
        }

        public void Save()
        {
            _unitOfWork.Comid();
        }

        public void Update(ProductCategory productCategory)
        {
            _productCategoryReponsitory.Update(productCategory);
        }
    }
}
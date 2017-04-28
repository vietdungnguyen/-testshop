using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestShop.Common;
using TestShop.Data.Infrastructure;
using TestShop.Data.Reponsitories;
using TestShop.Model.Models;

namespace TestShop.Service
{
    public interface IProductService
    {
        Product Add(Product Product);

        void Update(Product Product);

        Product Delete(int ID);

        IEnumerable<Product> GetAll();
        IEnumerable<Product> GetAll(string keyword);

        IEnumerable<Product> GetAllPaging(int page, int pageSize, out int totalRow);

        Product GetById(int id);
        IEnumerable<Product> GetAllByCategoryPaging(int categoryId, int page, int pageSize, out int totalRow);

        IEnumerable<Product> GetAllByTagPaging(string tag, int page, int pageSize, out int totalRow);

        void Save();
    }

    public class ProductService : IProductService
    {
        private IProductReponsitory _productReponsitory;
        private ITagReponsitory _tagReponsitory;
        private IProductTagReponsitory _productTagReponsitory;
        private IUnitOfWork _unitOfWork;
        public ProductService(IProductReponsitory productReponsitory, IProductTagReponsitory productTagReponsitory, ITagReponsitory tagReponsitory, IUnitOfWork unitOfWork)
        {
            this._productReponsitory = productReponsitory;
            this._productTagReponsitory = productTagReponsitory;
            this._tagReponsitory = tagReponsitory;
            this._unitOfWork = unitOfWork;
        }
        public Product Add(Product Product)
        {
            var product= _productReponsitory.Add(Product);
            _unitOfWork.Comid();
            if (!string.IsNullOrEmpty(Product.Tags))
            {
                string[] tags = Product.Tags.Split(',');
                for(var i=0;i<tags.Length;i++)
                {
                    var tagId = StringHelper.ToUnsignString(tags[i]);
                    if(_tagReponsitory.Count(x=>x.ID==tagId)==0)
                    {
                        Tag tag = new Tag();
                        tag.ID = tagId;
                        tag.Name = tags[i];
                        tag.Type = CommonConstants.ProductTag;
                        _tagReponsitory.Add(tag);
                    }
                    ProductTag productTag = new ProductTag();
                    productTag.ProductID = Product.ID;
                    productTag.TagID = tagId;
                    _productTagReponsitory.Add(productTag);
                }
            }
            return product;
        }

        public Product Delete(int id)
        {
            return _productReponsitory.Delete(id);
        }

        public IEnumerable<Product> GetAll()
        {
            return _productReponsitory.GetAll(new string[] { "ProductCategory" });
        }

        public IEnumerable<Product> GetAll(string keyword)
        {
            if(!string.IsNullOrEmpty(keyword))
            {
                return _productReponsitory.GetMulti(x => x.Name.Contains(keyword) || x.Description.Contains(keyword));
            }
            else
            return _productReponsitory.GetAll();
        }

        public IEnumerable<Product> GetAllByCategoryPaging(int categoryId, int page, int pageSize, out int totalRow)
        {
            return _productReponsitory.GetMultiPaging(x => x.status && x.CategoryID == categoryId, out totalRow, page, pageSize, new string[] { "ProductCategory" });
        }

        public IEnumerable<Product> GetAllByTagPaging(string tag, int page, int pageSize, out int totalRow)
        {
            //TODO
            return _productReponsitory.GetAllByTag(tag, page, pageSize, out totalRow);
        }

        public IEnumerable<Product> GetAllPaging(int page, int pageSize, out int totalRow)
        {
            return _productReponsitory.GetMultiPaging(x => x.status, out totalRow, page, pageSize);

        }

        public Product GetById(int id)
        {
            return _productReponsitory.GetSingleById(id);
        }

        public void Save()
        {
            _unitOfWork.Comid();
        }

        public void Update(Product Product)
        {
            _productReponsitory.Update(Product);
            if (!string.IsNullOrEmpty(Product.Tags))
            {
                string[] tags = Product.Tags.Split(',');
                for (var i = 0; i < tags.Length; i++)
                {
                    var tagId = StringHelper.ToUnsignString(tags[i]);
                    if (_tagReponsitory.Count(x => x.ID == tagId) == 0)
                    {
                        Tag tag = new Tag();
                        tag.ID = tagId;
                        tag.Name = tags[i];
                        tag.Type = CommonConstants.ProductTag;
                        _tagReponsitory.Add(tag);
                    }
                    _productTagReponsitory.DeleteMulti(x => x.ProductID == Product.ID);
                    ProductTag productTag = new ProductTag();
                    productTag.ProductID = Product.ID;
                    productTag.TagID = tagId;
                    _productTagReponsitory.Add(productTag);
                }               
            }
        }
    }
}

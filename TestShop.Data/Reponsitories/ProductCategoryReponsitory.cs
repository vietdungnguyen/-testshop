﻿using System.Collections.Generic;
using TestShop.Data.Infrastructure;
using TestShop.Model.Models;
using System.Linq;

namespace TestShop.Data.Reponsitories
{
    public interface IProductCategoryRepository : IReponsitory<ProductCategory>
    {
        IEnumerable<ProductCategory> GetByAlias(string alias);
    }

    public class ProductCategoryReponsitory : RepositoryBase<ProductCategory>,IProductCategoryRepository
    {
        public ProductCategoryReponsitory(IDbFactory dbFactory) : base(dbFactory)
        {
        }
        public IEnumerable<ProductCategory> GetByAlias(string alias)
        {
            return this.DbContext.ProductCategories.Where(x => x.Alias == alias);
        }
    }
}
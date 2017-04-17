using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestShop.Data.Infrastructure;
using TestShop.Model.Models;

namespace TestShop.Data.Reponsitories
{
    public interface IProductReponsitory : IReponsitory<Product>
    {

    }
    public class ProductReponsitory : RepositoryBase<Product>, IProductReponsitory
    {
        public ProductReponsitory(IDbFactory dbFactory) : base(dbFactory)
        {

        }
    }
}

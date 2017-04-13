using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestShop.Data.Infrastructure;
using TestShop.Model.Models;

namespace TestShop.Data.Reponsitories
{
    public interface IProductReponsitory
    {

    }
    public class ProductReponsitory : RepositoryBase<Product>
    {
        public ProductReponsitory(IDbFactory dbFactory) : base(dbFactory)
        {

        }
    }
}

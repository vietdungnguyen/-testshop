using TestShop.Data.Infrastructure;
using TestShop.Model.Models;

namespace TestShop.Data.Reponsitories
{
    public interface IProductTagReponsitory
    {
    }

    public class ProductTagReponsitory : RepositoryBase<ProductTag>, IProductTagReponsitory
    {
        public ProductTagReponsitory(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}
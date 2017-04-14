using TestShop.Data.Infrastructure;
using TestShop.Model.Models;

namespace TestShop.Data.Reponsitories
{
    public interface IOrderReponsitory
    {
    }

    public class OrderReponsitory : RepositoryBase<Order>, IOrderReponsitory
    {
        public OrderReponsitory(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}
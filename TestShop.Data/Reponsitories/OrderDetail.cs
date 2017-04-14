using TestShop.Data.Infrastructure;
using TestShop.Model.Models;

namespace TestShop.Data.Reponsitories
{
    public interface IOrderDetailReponsitory
    {
    }

    public class OrderDetailReponsitory : RepositoryBase<OrderDetail>, IOrderDetailReponsitory
    {
        public OrderDetailReponsitory(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}
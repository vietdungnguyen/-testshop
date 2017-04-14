using TestShop.Data.Infrastructure;
using TestShop.Model.Models;

namespace TestShop.Data.Reponsitories
{
    public interface ISystemConfigReponsitory
    {
    }

    public class SystemConfigReponsitory : RepositoryBase<OrderDetail>, ISystemConfigReponsitory
    {
        public SystemConfigReponsitory(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}
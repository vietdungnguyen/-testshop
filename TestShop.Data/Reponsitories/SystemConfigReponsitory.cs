using TestShop.Data.Infrastructure;
using TestShop.Model.Models;

namespace TestShop.Data.Reponsitories
{
    public interface ISystemConfigReponsitory : IReponsitory<SystemConfig>
    {
    }

    public class SystemConfigReponsitory : RepositoryBase<SystemConfig>, ISystemConfigReponsitory
    {
        public SystemConfigReponsitory(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}
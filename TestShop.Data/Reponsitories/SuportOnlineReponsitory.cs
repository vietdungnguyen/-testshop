using TestShop.Data.Infrastructure;
using TestShop.Model.Models;

namespace TestShop.Data.Reponsitories
{
    public interface ISuportOnlineReponsitory : IReponsitory<SuportOnline>
    {
    }

    public class SuportOnlineReponsitory : RepositoryBase<SuportOnline>, ISuportOnlineReponsitory
    {
        public SuportOnlineReponsitory(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}
using TestShop.Data.Infrastructure;
using TestShop.Model.Models;

namespace TestShop.Data.Reponsitories
{
    public interface IPageReponsitory : IReponsitory<Page>
    {
    }

    public class PageReponsitory : RepositoryBase<Page>, IPageReponsitory
    {
        public PageReponsitory(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}
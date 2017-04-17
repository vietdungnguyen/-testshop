using TestShop.Data.Infrastructure;
using TestShop.Model.Models;

namespace TestShop.Data.Reponsitories
{
    public interface IFooterReponsitory : IReponsitory<Footer>
    {
    }

    public class FooterReponsitory : RepositoryBase<Footer>,IFooterReponsitory
    {
        public FooterReponsitory(IDbFactory dbFactory):base(dbFactory)
        {

        }
    }
}
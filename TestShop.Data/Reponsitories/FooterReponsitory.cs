using TestShop.Data.Infrastructure;
using TestShop.Model.Models;

namespace TestShop.Data.Reponsitories
{
    public interface IFooterReponsitory
    {
    }

    public class FooterReponsitory : RepositoryBase<Footer>,IFooterReponsitory
    {
        public FooterReponsitory(IDbFactory dbFactory):base(dbFactory)
        {

        }
    }
}
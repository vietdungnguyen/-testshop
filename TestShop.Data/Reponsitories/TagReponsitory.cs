using TestShop.Data.Infrastructure;
using TestShop.Model.Models;

namespace TestShop.Data.Reponsitories
{
    public interface ITagReponsitory
    {
    }

    public class TagReponsitory : RepositoryBase<Tag>, ITagReponsitory
    {
        public TagReponsitory(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}
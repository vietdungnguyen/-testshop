using TestShop.Data.Infrastructure;
using TestShop.Model.Models;

namespace TestShop.Data.Reponsitories
{
    public interface IPostTagReponsitory : IReponsitory<PostTag>
    {
    }

    public class PostTagReponsitory : RepositoryBase<PostTag>, IPostTagReponsitory
    {
        public PostTagReponsitory(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}
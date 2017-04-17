using TestShop.Data.Infrastructure;
using TestShop.Model.Models;

namespace TestShop.Data.Reponsitories
{
    public interface IPostCategoryReponsitory : IReponsitory<PostCategory>
    {
    }

    public class PostCategoryReponsitory : RepositoryBase<PostCategory>, IPostCategoryReponsitory
    {
        public PostCategoryReponsitory(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}
using TestShop.Data.Infrastructure;
using TestShop.Model.Models;

namespace TestShop.Data.Reponsitories
{
    public interface ISlideReponsitory
    {
    }

    public class SlideReponsitory : RepositoryBase<OrderDetail>, ISlideReponsitory
    {
        public SlideReponsitory(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}
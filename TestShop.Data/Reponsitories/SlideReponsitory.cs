using TestShop.Data.Infrastructure;
using TestShop.Model.Models;

namespace TestShop.Data.Reponsitories
{
    public interface ISlideReponsitory : IReponsitory<Slide>
    {
    }

    public class SlideReponsitory : RepositoryBase<Slide>, ISlideReponsitory
    {
        public SlideReponsitory(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}
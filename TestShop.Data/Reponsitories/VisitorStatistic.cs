using TestShop.Data.Infrastructure;

namespace TestShop.Data.Reponsitories
{
    public interface IVisitorStatistic : IReponsitory<VisitorStatistic>
    {
    }

    public class VisitorStatistic : RepositoryBase<VisitorStatistic>, IVisitorStatistic
    {
        public VisitorStatistic(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}
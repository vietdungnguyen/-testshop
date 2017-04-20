using TestShop.Data.Infrastructure;
using TestShop.Model.Models;

namespace TestShop.Data.Reponsitories
{
    public interface IErrorReponsitory : IReponsitory<Error>
    {
    }

    public class ErrorReponsitory : RepositoryBase<Error>, IErrorReponsitory
    {
        public ErrorReponsitory(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}
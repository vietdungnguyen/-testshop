using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestShop.Data.Infrastructure;
using TestShop.Model.Models;

namespace TestShop.Data.Reponsitories
{
    public interface IMenuReponsitory : IReponsitory<Menu>
    {

    }
    public class MenuReponsitory: RepositoryBase<Menu>,IMenuReponsitory
    {
        public MenuReponsitory(IDbFactory dbFactory):base(dbFactory)
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestShop.Data.Infrastructure;
using TestShop.Model.Models;

namespace TestShop.Data.Reponsitories
{
    public interface IMenuGroupReponsitory : IReponsitory<MenuGroup>
    {

    }
    public class MenuGroupReponsitory : RepositoryBase<MenuGroup>,IMenuGroupReponsitory
    {
        public MenuGroupReponsitory(IDbFactory dbFactory):base(dbFactory)
        {

        }
    }
}

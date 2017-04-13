using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestShop.Data.Infrastructure
{
    public class DbFactory : Disposable, IDbFactory
    {      
        private TestShopDbContext dbContext;

        public TestShopDbContext Init()
        {
            return dbContext ?? (dbContext = new TestShopDbContext());
        }

        protected override void DisposeCore()
        {
            if (dbContext != null)
                dbContext.Dispose();
        }
    }
}

using System;
using System.Collections.Generic;
using TestShop.Data.Infrastructure;
using TestShop.Model.Models;
using System.Linq;

namespace TestShop.Data.Reponsitories
{
    public interface IPostReponsitory : IReponsitory<Post>
    {
        IEnumerable<Post> GetAllByTag(string tag, int pageIndex, int pageSize, out int totalRow);
    }

    public class PostReponsitory : RepositoryBase<Post>, IPostReponsitory
    {
        public PostReponsitory(IDbFactory dbFactory) : base(dbFactory)
        {
        }

        public IEnumerable<Post> GetAllByTag(string tag, int pageIndex, int pageSize, out int totalRow)
        {
            var query = from p in DbContext.Posts
                        join pt in DbContext.PostTags
                        on p.ID equals pt.PostID
                        where pt.TagID == tag && p.Status
                        orderby p.CreatedDate descending
                        select p;
            totalRow = query.Count();
            query = query.Skip((pageIndex - 1) * pageSize).Take(pageSize);
            return query; 
        }
    }
}
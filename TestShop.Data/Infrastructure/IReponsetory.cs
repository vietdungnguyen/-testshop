using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace TestShop.Data.Infrastructure
{
    public interface IReponsetory<T> where T:class
    {
        //add new entity
        void Add(T entity);

        //updated entity
        void Update(T entity);

        //Delete entity
        void Delete(T entity);

        //Delete multi entity
        void DeleteMulti(Expression<Func<T, bool>> where);

        // get entity by id
        T GetSingleById(int id);

        T GetSingleByConditon(Expression<Func<T, bool>> expression, string[] includes=null);

        IQueryable<T> GetAll(string[] includes=null);

        IQueryable<T> GetMulti(Expression<Func<T, bool>> predicate,string[] includes=null);

        IQueryable<T> GetMultiPaging(Expression<Func<T, bool>>filter,out int total,int index=0,int size=50,string[] includes=null);

        int Count(Expression<Func<T,bool>> where);

        bool CheckContains(Expression<Func<T,bool>>predicate);


    }
}

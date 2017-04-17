using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestShop.Data.Infrastructure;
using TestShop.Data.Reponsitories;
using TestShop.Model.Models;

namespace TestShop.Service
{
    public interface IPostCategoryService
    {
        void Add(PostCategory postCategory);
        void Update(PostCategory postCategory);
        void Delete(int id);
        IEnumerable<PostCategory> GetAll();
        IEnumerable<PostCategory> GetAllByParentId(int parentId);
        PostCategory GetById(int id);
    }
    public class PostCategoryService : IPostCategoryService
    {
        IPostCategoryReponsitory _postCategoryReponsitory;
        IUnitOfWork _unitOfWork;
        public PostCategoryService(IPostCategoryReponsitory postCategoryReponsitory,IUnitOfWork unitOfWork)
        {
            this._postCategoryReponsitory = postCategoryReponsitory;
            this._unitOfWork = unitOfWork;
        }
        public void Add(PostCategory postCategory)
        {
            _postCategoryReponsitory.Add(postCategory);
        }

        public void Delete(int id)
        {
            _postCategoryReponsitory.Delete(id);
        }

        public IEnumerable<PostCategory> GetAll()
        {
            return _postCategoryReponsitory.GetAll();
        }

        public IEnumerable<PostCategory> GetAllByParentId(int parentId)
        {
            return _postCategoryReponsitory.GetMulti(x => x.status && x.ParentID == parentId);
        }

        public PostCategory GetById(int id)
        {
            return _postCategoryReponsitory.GetSingleById(id);
        }

        public void Update(PostCategory postCategory)
        {
            _postCategoryReponsitory.Update(postCategory);
        }
    }
}

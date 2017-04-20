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
        PostCategory Add(PostCategory postCategory);
        void Update(PostCategory postCategory);
        PostCategory Delete(int id);
        IEnumerable<PostCategory> GetAll();
        IEnumerable<PostCategory> GetAllByParentId(int parentId);
        PostCategory GetById(int id);

        void Save();
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
        public PostCategory Add(PostCategory postCategory)
        {
            return _postCategoryReponsitory.Add(postCategory);
        }

        public PostCategory Delete(int id)
        {
           return _postCategoryReponsitory.Delete(id);
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

        public void Save()
        {
            _unitOfWork.Comid();
        }

        public void Update(PostCategory postCategory)
        {
            _postCategoryReponsitory.Update(postCategory);
        }
    }
}

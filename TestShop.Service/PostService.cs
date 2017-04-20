using System;
using System.Collections.Generic;
using TestShop.Data.Infrastructure;
using TestShop.Data.Reponsitories;
using TestShop.Model.Models;
using System.Linq;

namespace TestShop.Service
{
    public interface IPostService
    {
        Post Add(Post post);

        void Update(Post post);

        Post Delete(int ID);

        IEnumerable<Post> GetAll();

        IEnumerable<Post> GetAllPaging(int page, int pageSize, out int totalRow);

        Post GetById(int id);
        IEnumerable<Post> GetAllByCategoryPaging(int categoryId, int page, int pageSize, out int totalRow);

        IEnumerable<Post> GetAllByTagPaging(string tag,int page, int pageSize, out int totalRow);

        void SaveChanges();
    }

    public class PostService : IPostService
    {
        IPostReponsitory _postReponsitory;
        IUnitOfWork _unitOfWork;
        public PostService(IPostReponsitory postReponsitory,IUnitOfWork unitOfWork)
        {
            this._postReponsitory = postReponsitory;
            this._unitOfWork = unitOfWork;
        }
        public Post Add(Post post)
        {
            return _postReponsitory.Add(post);
        }

        public Post Delete(int id)
        {
            return _postReponsitory.Delete(id);
        }

        public IEnumerable<Post> GetAll()
        {
            return _postReponsitory.GetAll(new string[] { "PostCategory" });
        }

        public IEnumerable<Post> GetAllByCategoryPaging(int categoryId, int page, int pageSize, out int totalRow)
        {
            return _postReponsitory.GetMultiPaging(x => x.status && x.CategoryID == categoryId,out totalRow,page,pageSize,new string[] { "PostCategory" });
        }

        public IEnumerable<Post> GetAllByTagPaging(string tag, int page, int pageSize, out int totalRow)
        {
            //TODO
            return _postReponsitory.GetAllByTag(tag,page,pageSize,out totalRow);
        }

        public IEnumerable<Post> GetAllPaging(int page, int pageSize, out int totalRow)
        {
            return _postReponsitory.GetMultiPaging(x => x.status, out totalRow, page, pageSize);

        }

        public Post GetById(int id)
        {
            return _postReponsitory.GetSingleById(id);
        }

        public void SaveChanges()
        {
            _unitOfWork.Comid();
        }

        public void Update(Post post)
        {
            _postReponsitory.Update(post);
        }
    }
}
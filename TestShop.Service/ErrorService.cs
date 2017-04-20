using System;
using TestShop.Data.Infrastructure;
using TestShop.Data.Reponsitories;
using TestShop.Model.Models;

namespace TestShop.Service
{
    public interface IErrorService
    {
        Error Create(Error error);

        void Save();
    }

    internal class ErrorService : IErrorService
    {
        IErrorReponsitory _errorReponsitory;

        IUnitOfWork _unitOfWork;

        public ErrorService(IErrorReponsitory errorReponsitory,IUnitOfWork unitOfWork)
        {
            this._errorReponsitory = errorReponsitory;
            this._unitOfWork = unitOfWork;
        }

        public Error Create(Error error)

        {
            return _errorReponsitory.Add(error);
        }

        public void Save()
        {
            _unitOfWork.Comid();
        }
    }
}
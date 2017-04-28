using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestShop.Common;
using TestShop.Data.Infrastructure;
using TestShop.Data.Reponsitories;
using TestShop.Model.Models;

namespace TestShop.Service
{
    public interface ICommonService
    {
        Footer GetFooter();
    }
    public class CommonService : ICommonService
    {
        IFooterReponsitory _footerReponsitory;
        IUnitOfWork _unitOfWork;
        public CommonService(IFooterReponsitory footerReponsitory, IUnitOfWork unitOfwork)
        {
            this._footerReponsitory = footerReponsitory;
            this._unitOfWork = unitOfwork;
        }
        public Footer GetFooter()
        {
            return _footerReponsitory.GetSingleByConditon(x=>x.ID==CommonConstants.DefaultFooterId);
        }
    }
}

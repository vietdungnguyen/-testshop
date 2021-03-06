﻿using TestShop.Data.Infrastructure;
using TestShop.Model.Models;

namespace TestShop.Data.Reponsitories
{
    public interface IOrderDetailReponsitory : IReponsitory<OrderDetail>
    {
    }

    public class OrderDetailReponsitory : RepositoryBase<OrderDetail>, IOrderDetailReponsitory
    {
        public OrderDetailReponsitory(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}
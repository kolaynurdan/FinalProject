using Core.Data_Access.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.Entity_Framework
{
    public class EfOrderDal:EfEntityRepositoryBase<Order,NorthwindContext>, IOrderDal
    {
    }
}

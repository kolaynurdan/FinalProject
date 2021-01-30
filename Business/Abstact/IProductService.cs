using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstact
{
    public interface IProductService
    {
        List<Product> GetAll();
    }
}

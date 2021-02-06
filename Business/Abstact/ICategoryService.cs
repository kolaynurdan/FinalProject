using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstact
{
    public interface ICategoryService
    {
        List<Category> GetAll();

        List<Category> GetAllById(int id);

    }
}

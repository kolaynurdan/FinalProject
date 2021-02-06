using Business.Abstact;
using DataAccess.Abstract;
using DataAccess.Concrete.Entity_Framework;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CategoryManager : ICategoryService
    {
        ICategoryDal _categoryDal;
        private EfProductDal efProductDal;

        public IEnumerable<object> GetByUnitPrice(int v1, int v2)
        {
            throw new NotImplementedException();
        }

        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        public CategoryManager(EfProductDal efProductDal)
        {
            this.efProductDal = efProductDal;
        }

        public List<Category> GetAll()
        {
            return _categoryDal.GetAll();
        }

        public Category GetAllById(int categoryId)
        {
            return _categoryDal.Get(c => c.CategoryId == categoryId);
        }

        List<Category> ICategoryService.GetAllById(int id)
        {
            throw new NotImplementedException();
        }
    }
}

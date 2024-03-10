using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CategoryManager : IGenericService<Category>
    {
        private readonly IGenericDal<Category> _genericDal;


        public CategoryManager(IGenericDal<Category> genericDal)
        {
            _genericDal = genericDal;
        }

        public void Add(Category entity)
        {
            _genericDal.Add(entity);
        }

        public void Delete(Category entity)
        {
            _genericDal.Delete(entity);
        }

        public List<Category> GetAll()
        {
          return _genericDal.GetAll();
        }

        public void Update(Category entity)
        {
            _genericDal.Update(entity);
        }
    }
}

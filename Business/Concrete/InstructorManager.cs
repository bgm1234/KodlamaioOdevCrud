using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrate;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class InstructorManager : IGenericService<Instructor>
    {
        private readonly IGenericDal<Instructor> _genericDal;

        public InstructorManager(IGenericDal<Instructor> genericDal)
        {
            _genericDal = genericDal;
        }
        public void Add(Instructor entity)
        {
           _genericDal.Add(entity);
        }

        public void Delete(Instructor entity)
        {
           _genericDal?.Delete(entity);
        }

        public List<Instructor> GetAll()
        {
            return _genericDal.GetAll();
        }

        public void Update(Instructor entity)
        {
            _genericDal.Update(entity);
        }
    }
}

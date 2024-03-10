using DataAccess.Abstract;
using Entities.Concrate;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete
{
    public class EfCoreInstructorDal : IGenericDal<Instructor>
    {
         List<Instructor> instructors;

        public EfCoreInstructorDal()
        {
            Instructor ınstructor = new Instructor();
            ınstructor.Id = 1;
            ınstructor.Name = "Engin";
            ınstructor.LastName = "Demiroğ";

            instructors = new List<Instructor> { ınstructor};
        }
        public void Add(Instructor entity)
        {
            instructors.Add(entity);
        }

        public void Delete(Instructor entity)
        {
            Instructor deletedInstructor = instructors.SingleOrDefault(x => x.Id == entity.Id);

            if (deletedInstructor != null)
            {
                instructors.Remove(deletedInstructor);
            }
        }

        public List<Instructor> GetAll()
        {
            return instructors;
        }

        public void Update(Instructor entity)
        {
            Instructor updatedInstructor = instructors.FirstOrDefault(x => x.Id == entity.Id);
            if (updatedInstructor != null)
            {  
                updatedInstructor.Name = entity.Name;
                updatedInstructor.LastName = entity.LastName;
            }
        }
    }
}

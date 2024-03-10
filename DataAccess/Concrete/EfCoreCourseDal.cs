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
    public class EfCoreCourseDal : IGenericDal<Course>
    {
        List<Course> courses;

        public EfCoreCourseDal()
        {
            Course course = new Course
            { Id=1 ,
              Name="course1" , 
              Description="course1 açıklama" ,
              ImageUrl="course1 url",
              CategoryId=1 , 
              InstructorId=1,
              Price=123.4 };

            Course course2 = new Course
            {
                Id = 2,
                Name = "course2",
                Description = "course2 açıklama",
                ImageUrl = "course2 url",
                CategoryId = 1,
                InstructorId = 1,
                Price = 145.4
            };

            courses = new List<Course> {  course , course2 };

        }
        public void Add(Course entity)
        {
            courses.Add(entity);
            Console.WriteLine(entity.Name + "efcore a eklendi.");
        }

        public void Delete(Course entity)
        {
            Course deletedCourse = courses.SingleOrDefault(x => x.Id == entity.Id);

            if (deletedCourse != null)
            {
                courses.Remove(deletedCourse);
            }
        }

        public List<Course> GetAll()
        {
            return courses;
        }

        public void Update(Course entity)
        {
            Course updatedCourse = courses.SingleOrDefault(x => x.Id == entity.Id);

            if (updatedCourse != null)
            {
                updatedCourse.Name = entity.Name;
                updatedCourse.Description = entity.Description;
                updatedCourse.Price = entity.Price;
                updatedCourse.CategoryId = entity.CategoryId;
                updatedCourse.InstructorId = entity.InstructorId;
            }
        }
    }
}

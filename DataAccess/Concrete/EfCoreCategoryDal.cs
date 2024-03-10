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
    public class EfCoreCategoryDal : IGenericDal<Category>
    {
        List<Category> categories;

        public EfCoreCategoryDal()
        {
            Category category = new Category();
            category.Id = 1;
            category.Name = "Programlama EfCore";

            Category category2 = new Category();
            category2.Id = 2;
            category2.Name = "denemeEfCore";

            categories = new List<Category> { category, category2 };
        }
        public void Add(Category entity)
        {
           categories.Add(entity);
        }

        public void Delete(Category entity)
        {
            Category deletedCategory = categories.SingleOrDefault(x => x.Id == entity.Id);

            if (deletedCategory != null)
            {
                categories.Remove(deletedCategory);
            }
        }

        public List<Category> GetAll()
        {
           return categories;
        }

        public void Update(Category entity)
        {
            Category updatedCategory = categories.SingleOrDefault(x => x.Id == entity.Id);
            if (updatedCategory != null)
            {
                updatedCategory.Name = entity.Name;
                Console.WriteLine(updatedCategory.Name );
            }
        }

       
    }
}

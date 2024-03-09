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
    public class TextCategoryDal : ICategoryDal
    {
        List<Category> categories;

        public TextCategoryDal() 
        {
           
            Category category2 = new Category();
            category2.Id = 2;
            category2.Name = "denemetxt";

            Category category3 = new Category();
            category3.Id = 4;
            category3.Name = "deneme";

            Category category = new Category();
            category.Id = 1;
            category.Name = "Programlama Text";


            categories = new List<Category> { category, category2 ,category3 };
        }
        public void Add(Category entity)
        {
            categories.Add(entity);
        }

        public void Delete(Category entity)
        {
            Category deletedCategory = categories.SingleOrDefault(x=> x.Id == entity.Id);

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
            Category updatedCategory = categories.SingleOrDefault(x=> x.Id == entity.Id);
            if (updatedCategory != null)
            {
                updatedCategory.Name = entity.Name;
                Console.WriteLine(updatedCategory.Name + "olarak text te güncellendi.");
            }
        }
    }
}

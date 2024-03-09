// See https://aka.ms/new-console-template for more information
using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete;
using Entities.Concrate;
using Entities.Concrete;

Console.WriteLine("Hello, World!");

Category category3 = new Category();
category3.Id = 3;
category3.Name = "deneme";


CategoryManager categoryManager = new CategoryManager(new EfCoreCategoryDal());
categoryManager.Add(category3);

var categories = categoryManager.GetAll();

foreach (var category in categories)
{
    Console.WriteLine(category.Name);
}

CategoryManager categoryManager1 = new CategoryManager(new TextCategoryDal());

var categories2 = categoryManager1.GetAll();

foreach (var category in categories2)
{
    Console.WriteLine(category.Name);
}

Category category1 = new Category();
category1.Id = 4;
category1.Name = "değişen deneme :)";

categoryManager1.Update(category1);

foreach (var category in categories2)
{
    Console.WriteLine(category.Name);
}

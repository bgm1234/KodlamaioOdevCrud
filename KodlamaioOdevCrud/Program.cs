// See https://aka.ms/new-console-template for more information
using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete;
using Entities.Concrate;
using Entities.Concrete;

Console.WriteLine("Hello, World!");

Category category3 = new Category();
category3.Id = 3;
category3.Name = "deneme eklenen category";

CategoryManager categoryManager2 = new CategoryManager(new EfCoreCategoryDal());

var categories3 = categoryManager2.GetAll();
foreach (var category in categories3)
{
    Console.WriteLine(category.Name);
}




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

var categories4 = categoryManager1.GetAll();

foreach (var category in categories4)
{
    Console.WriteLine(category.Name);
}


Course course = new Course();
course.Id = 5;
course.Name = "deneme kurs";
course.Description = "açıklama";
course.ImageUrl = "jkfj";
course.InstructorId = 1;
course.CategoryId = 2;
course.Price = 35.4;

CourseManager courseManager = new CourseManager(new EfCoreCourseDal());
var courses1 = courseManager.GetAll();
foreach (var x in courses1)
{
    Console.WriteLine(x.Name);
}

CourseManager courseManager2 = new CourseManager(new EfCoreCourseDal());
courseManager2.Add(course);
var courses = courseManager2.GetAll();

foreach(var x in courses )
{ 
    Console.WriteLine(x.Name);
}
using lesson_2.Models;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel;

namespace lesson_2.ViewComponents
{
    public class CategoryViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke(int? n)
        {
            List<Category> categories = new List<Category>(){
            new Category(1,"category1","category1"),
            new Category(2,"category2","category2"),
            new Category(3,"category3","category3"),
        };
            if (n != null)
            {
                var search = categories.Where(x => x.Id == n);
                return View(search);
            }
            else
            {
                return View(categories);
            }
        }
    }
}

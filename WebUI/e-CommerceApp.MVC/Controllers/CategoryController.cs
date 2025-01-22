using e_CommerceApp.DataLayer.ADC;
using e_CommerceApp.EntitiyLayer.Entities;
using Microsoft.AspNetCore.Mvc;

namespace e_CommerceApp.MVC.Controllers
{
    public class CategoryController : Controller
    {
        private readonly AppDbContext _appDbContext;

        public CategoryController(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IActionResult Index()
        {
            List<Category> categoryList = _appDbContext.Categories.ToList();
            return View(categoryList);
        }

        public IActionResult Create()
        {
            return View();
        }
    }
}
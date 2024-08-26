using Microsoft.AspNetCore.Mvc;
using WebApplication9.DAL;
namespace WebApplication9.Controllers
{
    
    public class CategoryController : Controller
    {
        public CategoryDAL CategoryDAL { get; set; }
        public CategoryController(IConfiguration configuration) { 
            CategoryDAL = new CategoryDAL(configuration);
        }
        public async Task<IActionResult> Index()
        {
            var categories = await CategoryDAL.GetAll();
            return View(categories);
        }
    }
}

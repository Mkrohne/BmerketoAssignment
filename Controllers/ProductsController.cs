using Microsoft.AspNetCore.Mvc;
using WebApp.Models.ViewModels;

namespace WebApp.Controllers
{
    public class ProductsController : Controller
    {
        public IActionResult Index()
        {

            return View();
        }
    }
}

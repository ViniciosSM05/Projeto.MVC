using Microsoft.AspNetCore.Mvc;
using Projeto.MVC.Models;
using Projeto.MVC.Models.DataAccess;

namespace Projeto.Api.Controllers
{
    public class HomeController(IConfiguration config) : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

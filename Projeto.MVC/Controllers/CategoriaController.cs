using Microsoft.AspNetCore.Mvc;
using Projeto.MVC.Models;
using Projeto.MVC.Models.DataAccess;

namespace Projeto.Api.Controllers
{
    public class CategoriaController(IConfiguration config) : Controller
    {
		public IActionResult Index()
		{
			return View();
		}

		[HttpGet("[controller]/[action]")]
        public IEnumerable<Categoria> Get() => new CategoriaDA(config).GetAll();

        [HttpPost("[controller]/[action]")]
        public Categoria Add([FromBody] Categoria categoria) => new CategoriaDA(config).Add(categoria);

        [HttpPut("[controller]/[action]")]
        public Categoria Update([FromBody] Categoria categoria) => new CategoriaDA(config).Update(categoria);

        [HttpDelete("[controller]/[action]/{id}")]
        public int Delete(Guid id) => new CategoriaDA(config).Delete(id);
    }
}

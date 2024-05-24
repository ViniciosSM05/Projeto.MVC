using Microsoft.AspNetCore.Mvc;
using Projeto.MVC.Models;
using Projeto.MVC.Models.DataAccess;

namespace Projeto.Api.Controllers
{
    public class UfController(IConfiguration config) : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet("[controller]/[action]")]
        public IEnumerable<Uf> Get() => new UfDA(config).GetAll();

        [HttpPost("[controller]/[action]")]
        public Uf Add([FromBody] Uf uf) => new UfDA(config).Add(uf);

        [HttpPut("[controller]/[action]")]
        public Uf Update([FromBody] Uf uf) => new UfDA(config).Update(uf);

        [HttpDelete("[controller]/[action]/{sigla}")]
        public int Delete(string sigla) => new UfDA(config).Delete(sigla);
    }
}

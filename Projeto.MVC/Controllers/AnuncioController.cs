using Microsoft.AspNetCore.Mvc;
using Projeto.MVC.Models;
using Projeto.MVC.Models.DataAccess;

namespace Projeto.Api.Controllers
{
    public class AnuncioController(IConfiguration config) : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet("[controller]/[action]")]
        public IEnumerable<Anuncio> Get() => new AnuncioDA(config).GetAll();

        [HttpPost("[controller]/[action]")]
        public Anuncio Add([FromBody] Anuncio anuncio) => new AnuncioDA(config).Add(anuncio);

        [HttpPut("[controller]/[action]")]
        public Anuncio Update([FromBody] Anuncio anuncio) => new AnuncioDA(config).Update(anuncio);

        [HttpDelete("[controller]/[action]/{id}")]
        public int Delete(Guid id) => new AnuncioDA(config).Delete(id);
    }
}

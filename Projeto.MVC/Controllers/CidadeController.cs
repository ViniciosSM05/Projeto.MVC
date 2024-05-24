using Microsoft.AspNetCore.Mvc;
using Projeto.MVC.Models;
using Projeto.MVC.Models.DataAccess;

namespace Projeto.Api.Controllers
{
    public class CidadeController(IConfiguration config) : Controller
    {
        [HttpGet("[controller]/[action]")]
        public IEnumerable<Cidade> Get() => new CidadeDA(config).GetAll();

        [HttpPost("[controller]/[action]")]
        public Cidade Add([FromBody] Cidade cidade) => new CidadeDA(config).Add(cidade);

        [HttpPut("[controller]/[action]")]
        public Cidade Update([FromBody] Cidade cidade) => new CidadeDA(config).Update(cidade);

        [HttpDelete("[controller]/[action]/{id}")]
        public int Delete(Guid id) => new CidadeDA(config).Delete(id);
    }
}

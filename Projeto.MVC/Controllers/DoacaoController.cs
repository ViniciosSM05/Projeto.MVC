using Microsoft.AspNetCore.Mvc;
using Projeto.MVC.Models;
using Projeto.MVC.Models.DataAccess;

namespace Projeto.Api.Controllers
{
    public class DoacaoController(IConfiguration config) : Controller
    {
        [HttpGet("[controller]/[action]")]
        public IEnumerable<Doacao> Get() => new DoacaoDA(config).GetAll();

        [HttpPost("[controller]/[action]")]
        public Doacao Add([FromBody] Doacao doacao) => new DoacaoDA(config).Add(doacao);

        [HttpPut("[controller]/[action]")]
        public Doacao Update([FromBody] Doacao doacao) => new DoacaoDA(config).Update(doacao);

        [HttpDelete("[controller]/[action]/{id}")]
        public int Delete(Guid id) => new DoacaoDA(config).Delete(id);
    }
}

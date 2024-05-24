using Microsoft.AspNetCore.Mvc;
using Projeto.MVC.Models;
using Projeto.MVC.Models.DataAccess;

namespace Projeto.Api.Controllers
{
    public class EnderecoUsuarioController(IConfiguration config) : Controller
    {
        [HttpGet("[controller]/[action]")]
        public IEnumerable<EnderecoUsuario> Get() => new EnderecoUsuarioDA(config).GetAll();

        [HttpPost("[controller]/[action]")]
        public EnderecoUsuario Add([FromBody] EnderecoUsuario endereco) => new EnderecoUsuarioDA(config).Add(endereco);

        [HttpPut("[controller]/[action]")]
        public EnderecoUsuario Update([FromBody] EnderecoUsuario uf) => new EnderecoUsuarioDA(config).Update(uf);

        [HttpDelete("[controller]/[action]/{id}")]
        public int Delete(Guid id) => new EnderecoUsuarioDA(config).Delete(id);
    }
}

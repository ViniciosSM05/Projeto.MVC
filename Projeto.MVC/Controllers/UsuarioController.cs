using Microsoft.AspNetCore.Mvc;
using Projeto.MVC.Models;
using Projeto.MVC.Models.DataAccess;

namespace Projeto.Api.Controllers
{
    public class UsuarioController(IConfiguration config) : Controller
    {
        [HttpGet("[controller]/[action]")]
        public IEnumerable<Usuario> Get() => new UsuarioDA(config).GetAll();

        [HttpPost("[controller]/[action]")]
        public Usuario Add([FromBody] Usuario usuario) => new UsuarioDA(config).Add(usuario);

        [HttpPut("[controller]/[action]")]
        public Usuario Update([FromBody] Usuario usuario) => new UsuarioDA(config).Update(usuario);

        [HttpDelete("[controller]/[action]/{id}")]
        public int Delete(Guid id) => new UsuarioDA(config).Delete(id);
    }
}

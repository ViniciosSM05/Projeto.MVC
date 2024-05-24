using Microsoft.AspNetCore.Mvc;
using Projeto.MVC.Models;
using Projeto.MVC.Models.DataAccess;

namespace Projeto.Api.Controllers
{
    public class ImagemAnuncioController(IConfiguration config) : Controller
    {
        [HttpGet("[controller]/[action]")]
        public IEnumerable<ImagemAnuncio> Get() => new ImagemAnuncioDA(config).GetAll();

        [HttpPost("[controller]/[action]")]
        public ImagemAnuncio Add([FromBody] ImagemAnuncio imagem) => new ImagemAnuncioDA(config).Add(imagem);

        [HttpPut("[controller]/[action]")]
        public ImagemAnuncio Update([FromBody] ImagemAnuncio doacao) => new ImagemAnuncioDA(config).Update(doacao);

        [HttpDelete("[controller]/[action]/{id}")]
        public int Delete(Guid id) => new ImagemAnuncioDA(config).Delete(id);
    }
}

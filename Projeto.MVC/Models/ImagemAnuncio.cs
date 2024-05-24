using Dapper.Contrib.Extensions;
using Projeto.MVC.Models.Base;

namespace Projeto.MVC.Models
{
    [Table("imagem_anuncio")]
    public class ImagemAnuncio : BaseModel
    {
        public bool Principal { get; set; }
        public required string Url { get; set; }
        public Guid Anuncio_Id { get; set; }
    }
}

using Dapper.Contrib.Extensions;
using Projeto.MVC.Models.Base;

namespace Projeto.MVC.Models
{
    [Table("doacao")]
    public class Doacao : BaseModel
    {
        public decimal Valor { get; set; }
        public DateTime Data { get; set; }
        public Guid Anuncio_Id { get; set; }
    }
}

using Dapper.Contrib.Extensions;
using Projeto.MVC.Models.Base;

namespace Projeto.MVC.Models
{
    [Table("categoria")]
    public class Categoria : BaseModel
    {
        public required string Nome { get; set; }
    }
}

using Dapper.Contrib.Extensions;
using Projeto.MVC.Models.Base;

namespace Projeto.MVC.Models
{
    [Table("cidade")]
    public class Cidade : BaseModel
    {
        public required string Nome { get; set; }
        public required string Uf { get; set; }
    }
}

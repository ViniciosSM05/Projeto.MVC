using Dapper.Contrib.Extensions;
using Projeto.MVC.Models.Base;

namespace Projeto.MVC.Models
{
    [Table("usuario")]
    public class Usuario : BaseModel
    {
        public required string Nome { get; set; }
        public required string Cpfcnpj { get; set; }
        public required string Celular { get; set; }
        public DateTime Data_Nascimento { get; set; }
        public required string Email { get; set; }
        public required string Senha { get; set; }
    }
}

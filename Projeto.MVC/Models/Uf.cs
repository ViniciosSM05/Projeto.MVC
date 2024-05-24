using Dapper.Contrib.Extensions;

namespace Projeto.MVC.Models
{
    [Table("uf")]
    public class Uf 
    {
        [Key]
        public required string Sigla { get; set; }
        public required string Nome { get; set; }
    }
}

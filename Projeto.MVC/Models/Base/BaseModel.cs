using Dapper.Contrib.Extensions;

namespace Projeto.MVC.Models.Base
{
    public abstract class BaseModel
    {
        protected BaseModel()
        {
            Id = Guid.NewGuid();
        }

        [Key]
        public Guid Id { get; set; }
    }
}

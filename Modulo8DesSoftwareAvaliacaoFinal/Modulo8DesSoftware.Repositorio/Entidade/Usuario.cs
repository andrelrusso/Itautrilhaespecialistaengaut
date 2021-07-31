using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Modulo8DesSoftware.Repositorio.Entidade
{
    [Table("Usuario")]
    public class Usuario
    {
        [Key]
        public string User { get; set; }
        public string Senha { get; set; }
    }
}

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ModeloDesSoftware.Repositorio.Entidade
{
    [Table("Usuario")]
    public class Usuario
    {
        [Key]
        public string User { get; set; }
        public string Senha { get; set; }
    }
}

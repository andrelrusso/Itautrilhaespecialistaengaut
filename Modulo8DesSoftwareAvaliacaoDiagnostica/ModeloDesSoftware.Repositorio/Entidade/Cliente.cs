using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ModeloDesSoftware.Repositorio.Entidade
{
    [Table("Cliente")]
    public class Cliente
    {
        [Key]
        public int IdCliente { get; set; }
        public string NomeCliente { get; set; }
        public string RG { get; set; }
        public string CPF { get; set; }
        public string Endereco { get; set; }
        public string Produto { get; set; }
        public decimal PrecoVenda { get; set; }
    }
}

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Modulo8DesSoftware.Repositorio.Entidade
{
    [Table("Produto")]
    public class Produto
    {
        [Key]
        public int IdProduto { get; set; }
        public string NomeProduto { get; set; }
        public string Categoria { get; set; }
        public int QtdeEstoque { get; set; }
        public decimal PrecoVenda { get; set; }
    }
}

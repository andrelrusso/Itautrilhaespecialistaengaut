using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Modulo8DesSoftware.Web.Models
{
    public class ProdutoViewModel
    {
        public int IdProduto { get; set; }
        public string NomeProduto { get; set; }
        public string Categoria { get; set; }
        public int QtdeEstoque { get; set; }
        public decimal PrecoVenda { get; set; }
    }
}

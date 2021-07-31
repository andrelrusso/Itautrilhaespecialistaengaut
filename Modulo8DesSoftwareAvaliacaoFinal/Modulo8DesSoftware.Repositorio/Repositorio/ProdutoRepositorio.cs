using Modulo8DesSoftware.Repositorio.Context;
using Modulo8DesSoftware.Repositorio.Entidade;
using Modulo8DesSoftware.Repositorio.Interfaces;

namespace Modulo8DesSoftware.Repositorio.Repositorio
{
    public class ProdutoRepositorio : BaseRepositorio<Produto>, IProdutoRepositorio
    {
        public ProdutoRepositorio(EFContexto context) : base(context)
        {
        }
    }
}

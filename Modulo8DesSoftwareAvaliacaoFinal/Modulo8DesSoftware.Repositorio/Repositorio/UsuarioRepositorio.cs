using Modulo8DesSoftware.Repositorio.Context;
using Modulo8DesSoftware.Repositorio.Entidade;
using Modulo8DesSoftware.Repositorio.Interfaces;

namespace Modulo8DesSoftware.Repositorio.Repositorio
{
    public class UsuarioRepositorio : BaseRepositorio<Usuario>, IUsuarioRepositorio
    {
        public UsuarioRepositorio(EFContexto context) : base(context)
        {
        }
    }
}

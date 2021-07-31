using ModeloDesSoftware.Repositorio.Context;
using ModeloDesSoftware.Repositorio.Entidade;
using ModeloDesSoftware.Repositorio.Interfaces;

namespace ModeloDesSoftware.Repositorio.Repositorio
{
    public class UsuarioRepositorio : BaseRepositorio<Usuario>, IUsuarioRepositorio
    {
        public UsuarioRepositorio(EFContexto context) : base(context)
        {
        }
    }
}

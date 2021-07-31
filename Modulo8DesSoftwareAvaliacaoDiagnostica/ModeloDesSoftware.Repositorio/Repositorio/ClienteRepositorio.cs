using ModeloDesSoftware.Repositorio.Context;
using ModeloDesSoftware.Repositorio.Entidade;
using ModeloDesSoftware.Repositorio.Interfaces;

namespace ModeloDesSoftware.Repositorio.Repositorio
{
    public class ClienteRepositorio : BaseRepositorio<Cliente>, IClienteRepositorio
    {
        public ClienteRepositorio(EFContexto context) : base(context)
        {
        }
    }
}

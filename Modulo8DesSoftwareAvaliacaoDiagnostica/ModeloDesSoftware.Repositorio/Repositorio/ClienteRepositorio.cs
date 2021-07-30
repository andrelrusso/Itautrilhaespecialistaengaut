using ModeloDesSoftware.Repositorio.Entidade;


namespace ModeloDesSoftware.Repositorio.Repositorio
{
    public class ClienteRepositorio : BaseRepositorio<Cliente>, IClienteRepositorio
    {
        public ClienteRepositorio(EFContexto context) : base(context)
        {
        }
    }
}

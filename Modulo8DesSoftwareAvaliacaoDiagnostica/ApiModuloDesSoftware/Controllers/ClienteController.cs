using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ModeloDesSoftware.Repositorio.Entidade;
using ModeloDesSoftware.Repositorio.Interfaces;

namespace ApiModuloDesSoftware.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class ClienteController : ControllerBase
    {
        private readonly IClienteRepositorio repositorioCliente;
        public ClienteController(IClienteRepositorio reposCliente)
        {
            repositorioCliente = reposCliente;
        }
        [HttpPost(nameof(InsertCliente))]
        public void InsertCliente(Cliente cliente)
        {
            repositorioCliente.Adicionar(cliente);
        }
    }
}
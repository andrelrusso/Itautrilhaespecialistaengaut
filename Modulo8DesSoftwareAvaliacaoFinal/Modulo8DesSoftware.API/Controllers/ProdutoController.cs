using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Modulo8DesSoftware.Repositorio.Entidade;
using Modulo8DesSoftware.Repositorio.Interfaces;

namespace Modulo8DesSoftware.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class ProdutoController : ControllerBase
    {
        private readonly IProdutoRepositorio repositorio;
        public ProdutoController(IProdutoRepositorio repos)
        {
            repositorio = repos;
        }
        [HttpPost(nameof(Insert))]
        public void Insert(Produto produto)
        {
            repositorio.Adicionar(produto);
        }
    }
}
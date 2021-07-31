using Microsoft.AspNetCore.Mvc;
using Modulo8DesSoftware.Repositorio.Entidade;
using Modulo8DesSoftware.Web.Models;
using Modulo8DesSoftware.Web.Util;

namespace Modulo8DesSoftware.Web.Controllers
{
    public class ProdutoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Cadastrar(ProdutoViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(nameof(Index), model);

            }
            var apiclient = new ApiClient("https://localhost:44350/api/");
            var usuario = new Usuario
            {
                User = "Andre",
                Senha = "*tgs123*"
            };

            var jwt = apiclient.Post<string>("Usuario/GetToken", usuario);

            apiclient.AddHeader("Authorization", $"Bearer {jwt}");
            apiclient.Post("Produto/Insert", model);
            return RedirectToAction(nameof(Index));

        }
    }
}
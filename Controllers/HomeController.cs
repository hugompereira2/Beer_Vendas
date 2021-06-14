using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Beer_Vendas.Models;
using Converte_Object_Json;
using System.Buffers.Text;
using Base64 = Beer_Vendas.Models.Base64;

namespace Beer_Vendas.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public async Task<ActionResult> Index()
        {
            Repositorio repositorio = new Repositorio();

            Usuario Usuario = new Usuario();
            Base64 img = new Base64();
            Produto produto = new Produto();

            var teste = repositorio.GetUsuariosAsync();
            ViewBag.teste = teste;


            var userId = Request.Cookies["Usuario"];

            ViewBag.UserId = (userId == null) ? 2 : 1;

            var Usuarios = await repositorio.GetUsuariosAsync();
            ViewBag.teste = Usuarios;


            var Produtos = await repositorio.GetProdutosAsync();

            ViewBag.Produtos = Produtos;

            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

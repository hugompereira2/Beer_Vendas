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
using Newtonsoft.Json;
using Base64 = Beer_Vendas.Models.Base64;
using Microsoft.AspNetCore.Http;

namespace Beer_Vendas.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        [HttpPost]
        public JsonResult Login(Usuario usuario)
        {

            Retorno ret = new Retorno();
            //Repositorio repositorio = new Repositorio();

            //var retorno = repositorio.GetPedidosAsync();
            //ViewBag.retorno = retorno;

            // Fazer a verificação do usuario e senha com API e fazer o retorno

            CookieOptions option = new CookieOptions();

            option.Expires = DateTime.Now.AddMinutes(10);

            var user = Convert.ToString(usuario.usu_id);

            Response.Cookies.Append("Usuario", "2", option);

            var teste = Request.Cookies["Usuario"];


            ret.Mensagem = "Deu certo";
            ret.Sucesso = true;

            return Json(ret);

        }

        [HttpGet]
        public ActionResult Index()
        {
            Repositorio repositorio = new Repositorio();

            Usuario Usuario = new Usuario();
            Base64 img = new Base64();
            Produto produto = new Produto();

            var userId = Request.Cookies["Usuario"];

            ViewBag.UserId = (userId != null && userId != "0") ? int.Parse(userId) : 0;

            //var Usuarios = repositorio.GetUsuariosAsync();
            //ViewBag.teste = Usuarios;

            //var Produtos = repositorio.GetProdutosAsync();

            //foreach (var item in Produtos.Result)
            //{

            //}
            //ViewBag.Produtos = Produtos;

            return View();
        }
        public ActionResult Catalogo()
        {
            return View();
        }
        public ActionResult Sobre()
        {
            return View();
        }
        public ActionResult Contato()
        {
            return View();
        }
        public ActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }

}

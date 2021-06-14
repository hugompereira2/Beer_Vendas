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
using pedido = Beer_Vendas.Models.Pedido;
using Newtonsoft.Json;

namespace Beer_Vendas.Controllers
{
    public class PedidoController : Controller
    {
        public IActionResult Solicitacao()
        {
            pedido pedido = new pedido();
            Repositorio repositorio = new Repositorio();

            var pedidos = repositorio.GetPedidosAsync();
            ViewBag.pedidos = pedidos;

            var userId = Request.Cookies["Usuario"];

            if (userId == "0")
            {
                ViewBag.userId = "0";
                ViewBag.Nome = "Admin";
                return View();
            }
            else if (userId == "1")
            {
                ViewBag.userId = "1";
                ViewBag.Nome = "Felipe";
                return View();
            }

            return View();
        }

        public IActionResult SolicitacaoUser()
        {
            pedido pedido = new pedido();
            Repositorio repositorio = new Repositorio();

            var pedidos = repositorio.GetPedidosAsync();
            ViewBag.pedidos = pedidos;

            var userId = Request.Cookies["Usuario"];

            if (userId == "0")
            {
                ViewBag.userId = "0";
                ViewBag.Nome = "Admin";
                return View();
            }
            else if (userId == "1")
            {
                ViewBag.userId = "1";
                ViewBag.Nome = "Felipe";
                return View();
            }

            return View();
        }

        public ActionResult Carrinho()
        {

            Repositorio repositorio = new Repositorio();

            Usuario Usuario = new Usuario();
            var userId = Request.Cookies["Usuario"];

            ViewBag.UserId = (userId != null && userId != "0") ? int.Parse(userId) : 0;

            var Usuarios = repositorio.GetUsuariosAsync();
            ViewBag.teste = Usuarios;
            //var cookie = Request.Cookies["Usuario"];
            //if (cookie == "0" || cookie == null)
            //{
            //    ViewBag.ExibirLogin = true;

            //    return RedirectToAction("Index", "Home");
            //}

            return View();
        }

    }
}

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

namespace Beer_Vendas.Controllers
{
    public class PedidoController : Controller
    {
        public IActionResult Solicitacao()
        {
            pedido pedido = new pedido();
            UsuarioRepositorio repositorio = new UsuarioRepositorio();

            var pedidos = repositorio.GetPedidosAsync();
            ViewBag.pedidos = pedidos;

            return View();
        }

    }
}

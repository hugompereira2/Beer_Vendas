using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Beer_Vendas.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using produto = Beer_Vendas.Models.Produto;

namespace Beer_Vendas.Controllers
{
    public class ProdutoController : Controller
    {
        // GET: Produto
        public ActionResult Listar()
        {
            Repositorio repositorio = new Repositorio();
            produto produto = new produto();

            var Produtos = repositorio.GetProdutosAsync();
            ViewBag.Produtos = Produtos;

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

        [HttpGet]
        public ActionResult Cadastrar()
        {
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

        [HttpPost]
        public ActionResult Cadastrar(produto produto, IFormFile imagem)
        {
            //System.Threading.Thread.Sleep(3000);
            Repositorio repositorio = new Repositorio();
            Retorno ret = new Retorno();

            try
            {
                if (imagem.Length > 0)
                {
                    using (var ms = new MemoryStream())
                    {
                        imagem.CopyTo(ms);
                        var fileBytes = ms.ToArray();
                        string s = Convert.ToBase64String(fileBytes);
                        produto.pro_imagem = s;

                        //produto.pro_imagem = fileBytes;
                    }
                    
                    repositorio.PostProdutos(produto);
                    ret.Mensagem = "Cadastro com Sucesso!";
                    ret.Sucesso = true;

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
                }
            }
            catch
            {
                throw;
            }

            return Json(ret);
        }

        // POST: Produto/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

    }
}
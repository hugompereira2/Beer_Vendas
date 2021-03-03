using System;
using System.Collections.Generic;
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

            //foreach (var item in Produtos.Result)
            //{

            //}
            ViewBag.Produtos = Produtos;

            return View();
        }

        // GET: Produto/Details/5
        public ActionResult Cadastrar()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Cadastrar(produto produto)
        {
            System.Threading.Thread.Sleep(3000);
            Repositorio repositorio = new Repositorio();
            Retorno ret = new Retorno();

            try
            {
                //repositorio.PostProdutos(produto);
                ret.Mensagem = "Cadastro com Sucesso!";
                ret.Sucesso = true;
            }
            catch
            {
                throw;
            }

            return Json(ret);
        }

        // GET: Produto/Create
        public ActionResult Create()
        {
            return View();
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

        // GET: Produto/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Produto/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Produto/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Produto/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
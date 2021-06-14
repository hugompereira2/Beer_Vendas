using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Beer_Vendas.Models;
namespace Beer_Vendas.Controllers
{
    public class UsuarioController : Controller
    {
        // GET: Usuario
        public ActionResult Home()
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
            else
            {
                return RedirectToAction("Index", "Home");
            }

        }

        [HttpPost]
        public async Task<ActionResult> LoginAsync(Usuario usuario)
        {
            Login login = new Login();
            CookieOptions option = new CookieOptions();
            Repositorio repositorio = new Repositorio();

            login.usu_login = usuario.usu_email;
            login.usu_senha = usuario.usu_senha;

            var response = await repositorio.GetLogin(login);
            option.Expires = DateTime.Now.AddMinutes(3600);
            if (response)
            {
                if (login.usu_login.Contains("admin") || login.usu_login.Contains("hugo"))
                {
                    Response.Cookies.Append("Usuario", "0", option);    
                }
                else
                {
                    Response.Cookies.Append("Usuario", "1", option);

                }

                return RedirectToAction("home", "usuario");
            }
            else
            {
                throw new InvalidOperationException("Usuario e senha incorretos");
            }            
        }

        // GET: Usuario/Details/5
        public ActionResult Listar()
        {
            Repositorio repositorio = new Repositorio();

            var usuarios = repositorio.GetUsuariosAsync();
            ViewBag.usuarios = usuarios;

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

        // GET: Usuario/Create
        public ActionResult Create()
        {
            return View();
        }

        public ActionResult Cadastrar(Usuario usuario)
        {
            try
            {
                Repositorio repositorio = new Repositorio();
                CookieOptions option = new CookieOptions();

                usuario.usu_login = usuario.usu_email;
                repositorio.CriarUsuario(usuario);
                option.Expires = DateTime.Now.AddMinutes(3600);
                Response.Cookies.Append("Usuario", usuario.usu_email, option);
                return RedirectToAction("Home");
            }
            catch
            {
                throw;
            }

        }
    }
}
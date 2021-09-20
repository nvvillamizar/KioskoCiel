using Ciel.Prueba.NetCore.Filters;
using KioskoDatos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kiosko.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public string Login(string username, string password)
        {
            UsuariosDat datosUsuario = new();

            string idUsuario = datosUsuario.Autenticar(username, password);

            if (idUsuario == null) return "ERROR";

            HttpContext.Session.SetString("usuario", idUsuario);

            return "OK";
        }

        public ActionResult Logout()
        {
            HttpContext.Session.Remove("usuario");
            return RedirectToAction("Login");
        }
    }
}

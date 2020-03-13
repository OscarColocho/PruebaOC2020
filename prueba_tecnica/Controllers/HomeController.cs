using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using prueba_tecnica.Models;

namespace prueba_tecnica.Controllers
{
    public class HomeController : Controller
    {

        private aplicacion1Entities db = new aplicacion1Entities();
        public ActionResult Index()
        {
            return View();
        }

        // GET: Home
        public ActionResult Index(string message = "")
        {
            ViewBag.Message = message;
            return View();
        }

        [HttpPost]
        public ActionResult Login(string usuario, string correo) 
        {
            if (string.IsNullOrEmpty(usuario) && !string.IsNullOrEmpty(correo))
            {
                
                var user = db.Usuarios.FirstOrDefault(e => e.nomUsuario == usuario && e.correo == correo);
                if (user != null)
                {

                    FormsAuthentication.SetAuthCookie(user.nomUsuario, true);
                    return RedirectToAction("Index", "Profile");
                }
                else
                {

                    return RedirectToAction("Index", new { message = "No encontramos tus datos" });
                }
            }
            else
            {
                return RedirectToAction("Index", new { message = "llena los campos para iniciar sesion" });

            }

        }
    }
}
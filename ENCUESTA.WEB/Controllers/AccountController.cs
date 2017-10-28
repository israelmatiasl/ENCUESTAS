using ENCUESTA.WEB.ViewModel.AccountViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ENCUESTA.WEB.Models;

namespace ENCUESTA.WEB.Controllers
{
    public class AccountController : Controller
    {
        db_EncuestasEntities context = new db_EncuestasEntities();
        // GET: Account
        public ActionResult Login()
        {
            LoginViewModel objviewmodel = new LoginViewModel();
            return View(objviewmodel);
        }

        [HttpPost]
        public ActionResult Login(LoginViewModel objviewmodel)
        {
            try
            {
                Usuario usuario = context.Usuario.FirstOrDefault(x => x.email == objviewmodel.email && x.password == objviewmodel.password);
                if(usuario == null)
                {
                    //EMAIL O PASSWORD INCORRECTOS
                    return View();
                }
                Session["objusuario"] = usuario;

                return RedirectToAction("Index", "Home");
            }
            catch
            {
                return View();
            }
        }

        [HttpPost]
        public ActionResult Register(RegisterViewModel objviewmodel)
        {
            Usuario usuario = new Usuario();
            context.Usuario.Add(usuario);
            usuario.nombres = objviewmodel.nombres;
            usuario.email = objviewmodel.email;
            usuario.password = objviewmodel.password;

            context.SaveChanges();

            return RedirectToAction("Index", "Home");
        }

        public ActionResult SignOut()
        {
            Session["objusuario"] = null;
            return RedirectToAction("Index", "Home");
        }
    }
}
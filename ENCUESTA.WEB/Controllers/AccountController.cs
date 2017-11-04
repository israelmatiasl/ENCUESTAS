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
        [HttpPost]
        public ActionResult Login(FormCollection form)
        {
            try
            {
                String email = form["emaillogin"];
                String pass = form["passlogin"];
                Usuario usuario = context.Usuario.FirstOrDefault(x => x.email == email && x.password == pass);
                if(usuario == null)
                {
                    //EMAIL O PASSWORD INCORRECTOS
                    return RedirectToAction("Index", "Home");
                }
                Session["objusuario"] = usuario;

                return RedirectToAction("Index", "Home");
            }
            catch(Exception ex)
            {
                String mss = ex.Message;
                return RedirectToAction("Index", "Home");
            }
        }

        [HttpPost]
        public ActionResult Register(FormCollection form)
        {
            try
            {
                String name = form["namereg"];
                String email = form["emailreg"];
                String pass = form["passreg"];

                Usuario usuario = new Usuario();
                context.Usuario.Add(usuario);
                usuario.nombres = name;
                usuario.email = email;
                usuario.password = pass;

                context.SaveChanges();

                return RedirectToAction("Index", "Home");
            }
            catch
            {
                return RedirectToAction("Index", "Home");
            }
        }

        public ActionResult SignOut()
        {
            Session["objusuario"] = null;
            return RedirectToAction("Index", "Home");
        }
    }
}
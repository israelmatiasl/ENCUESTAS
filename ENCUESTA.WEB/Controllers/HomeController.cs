using ENCUESTA.WEB.Helpers;
using ENCUESTA.WEB.Models;
using ENCUESTA.WEB.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ENCUESTA.WEB.Controllers
{
    public class HomeController : Controller
    {
        db_EncuestasEntities context = new db_EncuestasEntities();
        public ActionResult Index()
        {
            return View();
        }
        
        [HttpPost]
        public ActionResult EnviarEncuesta(FormCollection formCollection)
        {
            String result = formCollection["rtotal"];

            Usuario usuario = Session["objusuario"] as Usuario;

            if(usuario != null)
            {
                Resultados resultados = new Resultados();
                context.Resultados.Add(resultados);
                resultados.usuarioid = usuario.usuarioid;
                resultados.resultadototal = result;
                resultados.fecharesultado = DateTime.Now;

                context.SaveChanges();
            }
            else
            {
                List<String> listadeRecomendaciones = GetRecomendaciones.MostrarRecomendaciones(result);
                TempData["lista"] = listadeRecomendaciones;
            }
            
            return RedirectToAction("ShowResult", "Result");
        }
        
    }
}
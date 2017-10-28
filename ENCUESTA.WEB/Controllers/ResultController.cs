using ENCUESTA.WEB.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ENCUESTA.WEB.ViewModel.RecomendacionesViewModel;

namespace ENCUESTA.WEB.Controllers
{
    public class ResultController : Controller
    {
        // GET: Result
        public ActionResult Index()
        {
            Usuario user = Session["objusuario"] as Usuario;
            if(user==null)
            {
                return RedirectToAction("Index", "Home");
            }

            ListRecomendacionesViewModel objviewmodel = new ListRecomendacionesViewModel();
            objviewmodel.todosresultados(user.usuarioid);

            return View(objviewmodel);
        }

        public ActionResult ShowResult(Int64? id)
        {
            try
            {
                ListRecomendacionesViewModel objviewmodel = new ListRecomendacionesViewModel();
                Usuario user = Session["objusuario"] as Usuario;
                List<String> resultadosamostrar = new List<String>();
                if (user != null)
                {
                    if (id.HasValue)
                    {
                        resultadosamostrar = objviewmodel.detailanyresultado(id.Value);
                    }
                    else
                    {
                        resultadosamostrar = objviewmodel.detailultimoresultado(user.usuarioid);
                    }
                }
                else
                {
                    objviewmodel.ultimoresultado = TempData["listaTotal"] as List<String>;
                    objviewmodel.mostrarRP = TempData["recomendP"] as List<String>;
                    objviewmodel.mostrarRS = TempData["recomendS"] as List<String>;
                    resultadosamostrar = objviewmodel.ultimoresultado;
                }

                if(resultadosamostrar is null)
                {
                    return RedirectToAction("Index", "Home");
                }

                return View(objviewmodel);
            }
            catch
            {
                return RedirectToAction("Index", "Home");
            }
            
        }
    }
}
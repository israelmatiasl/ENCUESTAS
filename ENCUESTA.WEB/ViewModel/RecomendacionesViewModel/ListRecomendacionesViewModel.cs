using ENCUESTA.WEB.Helpers;
using ENCUESTA.WEB.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ENCUESTA.WEB.ViewModel.RecomendacionesViewModel
{
    public class ListRecomendacionesViewModel
    {
        db_EncuestasEntities context = new db_EncuestasEntities();

        public List<Resultados> resultadostotales { get; set; }
        public List<String> ultimoresultado { get; set; }

        public ListRecomendacionesViewModel() { }

        public List<String> detailultimoresultado(Int64 idusuario)
        {
            String resultado = context.Resultados.Where(x=>x.usuarioid == idusuario).OrderByDescending(x => x.fecharesultado).Select(x=>x.resultadototal).FirstOrDefault();
            ultimoresultado = GetRecomendaciones.MostrarRecomendaciones(resultado);
            return ultimoresultado;
        }

        public void todosresultados(Int64 idusuario)
        {
            resultadostotales = context.Resultados.Where(x => x.usuarioid == idusuario).ToList();
        }

        public List<String> detailanyresultado(Int64 idresultado)
        {
            String resultado = context.Resultados.Where(x=>x.resultadosid == idresultado).Select(x => x.resultadototal).FirstOrDefault();
            ultimoresultado = GetRecomendaciones.MostrarRecomendaciones(resultado);
            return ultimoresultado;
        }
    }
}
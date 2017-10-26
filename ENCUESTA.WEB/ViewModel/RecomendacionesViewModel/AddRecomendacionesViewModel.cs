using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ENCUESTA.WEB.ViewModel.RecomendacionesViewModel
{
    public class AddRecomendacionesViewModel
    {
        public Int64 usuarioid { get; set; }
        public String recomendaciones { get; set; }
        public DateTime fecharesultado { get; set; }

        public AddRecomendacionesViewModel()
        {

        }
    }
}
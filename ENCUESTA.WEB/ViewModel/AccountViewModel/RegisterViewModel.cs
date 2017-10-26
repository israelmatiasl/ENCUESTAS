using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ENCUESTA.WEB.ViewModel.AccountViewModel
{
    public class RegisterViewModel
    {
        public String nombres { get; set; }
        public String email { get; set; }
        public String password { get; set; }

        public RegisterViewModel() { }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CadeMeuMedico.Controllers
{
    public class MenssagensController : Controller
    {
        public JavaScriptResult BomDia()
        {
            string js = @"alert('Bom dia, seja bem vindo ao Cade Meu Medico');";

            return JavaScript(js);
        }

        public ActionResult BoaTarde()
        {
            return Content("Boa tarde, Seja bem vindo ao Cade Meu Médico");
        }


    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AutenticacaoAspNet.Content
{
    public class AutenticacaoController : Controller
    {
        // GET: Autenticacao
        public ActionResult Cadastrar()
        {
            return View();
        }
    }
}
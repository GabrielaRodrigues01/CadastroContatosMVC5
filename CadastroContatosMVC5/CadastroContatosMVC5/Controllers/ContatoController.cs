using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CadastroContatosMVC5.Models;

namespace CadastroContatosMVC5.Controllers
{
    public class ContatoController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Index(ContatoModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            TempData["MensagemSucesso"] = "Contato cadastrado com sucesso!";
            return RedirectToAction("Sucesso");
        }

        public ActionResult Sucesso()
        {
            return View();
        }
    }
}
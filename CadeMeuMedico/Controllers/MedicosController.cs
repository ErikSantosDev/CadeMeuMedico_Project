using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CadeMeuMedico.Models;

namespace CadeMeuMedico.Controllers
{
    public class MedicosController : Controller
    {

        private CadeMeuMedicoBDEntities db = new CadeMeuMedicoBDEntities();
        // GET: Medicos
        public ActionResult Index()
        {
            var medico = new Medicos();

            var medicos = db.Medicos.Include(m => m.Cidades)
            .Include(m => m.Especialidades).ToList();
            return View(medicos);
        }

        public ActionResult Adcionar()
        {
            ViewBag.IDCidade = new SelectList(db.Cidades, "IDCidade", "Nome");
            ViewBag.IDEspecialidade = new SelectList(db.Especialidades, "IDEspecialidade", "Nome");
            return View();
        }

        [HttpPost]
        public ActionResult Adcionar(Medicos medico)
        {
            if (ModelState.IsValid)
            {
                db.Medicos.Add(medico);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.IDCidade = new SelectList(db.Cidades, "IDCidade","Nome", medico.IDCidade);
            ViewBag.IDEspecialidade = new SelectList(db.Especialidades,"IDEspecialidade","Nome",medico.IDEspecialidade);
            return View(medico);
        }
    }
}
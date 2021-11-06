using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCClinica.Data;
using MVCClinica.Models;

namespace MVCClinica.Controllers
{
    public class MedicosController : Controller
    {
        // GET: Medicos
        public ActionResult Index()
        {
            var medicos = AdmMedico.Listar();


            return View("Index", medicos);
        }

        public ActionResult Create()
        {
            Medico medico = new Medico();

            return View("Create", medico);
        }


        //Medicos/Create --> POST
        [HttpPost]
        public ActionResult Create(Medico medico)
        {
            if (ModelState.IsValid)
            {
                AdmMedico.Insertar(medico);
                return RedirectToAction("Index");
            }
            return View("Create", medico);
        }

        public ActionResult Detail(int id)
        {
            Medico medico = AdmMedico.GetPorId(id);
            if (medico != null)
            {
                return View("Detail", medico);
            }
            return HttpNotFound();
        }

        //Medicos/Edit --> Get
        public ActionResult Edit(int id)
        {
            Medico medico= AdmMedico.GetPorId(id);
            if (medico != null)
            {
                return View("Edit", medico);
            }
            return HttpNotFound();
        }

        //Medicos/Edit --> POST
        [HttpPost]
        [ActionName("Edit")]
        public ActionResult Edit(Medico medico)
        {
            if (ModelState.IsValid)
            {
                AdmMedico.Modificar(medico);
                return RedirectToAction("Index");
            }
            return View("Edit", medico);
        }

        //Opera/Delete/id --> GET
        //[HttpGet]
        public ActionResult Delete(int id)
        {
            Medico medico = AdmMedico.GetPorId(id);

            if (medico != null)
            {
                return View("Delete", medico);
            }
            else
            {
                return HttpNotFound();
            }
        }

        //Medicos/Delete  --> POST
        [HttpPost]
        [ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
         

            AdmMedico.Eliminar(id);

            return RedirectToAction("Index");
        }
    }
}
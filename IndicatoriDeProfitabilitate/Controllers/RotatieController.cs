using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IndicatoriDeProfitabilitate.Controllers
{
    public class RotatieController : Controller
    {
        private Repository.RotatieRepository rotatieRepository = new Repository.RotatieRepository();
        // GET: Rotatie
        public ActionResult Index()
        {
            List<Models.RotatieModel> rotatii = rotatieRepository.GetAllRotatii();
            return View("Index", rotatii);
        }

        // GET: Rotatie/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Rotatie/Create
        public ActionResult Create()
        {
            return View("CreateRotatie");
        }

        // POST: Rotatie/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                Models.RotatieModel rotatieModel = new Models.RotatieModel();
                UpdateModel(rotatieModel);
                rotatieRepository.InsertRotatie(rotatieModel);

                return RedirectToAction("Index");
            }
            catch
            {
                return View("CreateRotatie");
            }
        }

        // GET: Rotatie/Edit/5
        public ActionResult Edit(Guid id)
        {
            Models.RotatieModel rotatieModel = rotatieRepository.GetRotatieById(id);

            return View("EditRotatie", rotatieModel);
        }

        // POST: Rotatie/Edit/5
        [HttpPost]
        public ActionResult Edit(Guid id, FormCollection collection)
        {
            try
            {
                Models.RotatieModel rotatieModel = new Models.RotatieModel();
                UpdateModel(rotatieModel);
                rotatieRepository.UpdateRotatie(rotatieModel);
                return RedirectToAction("Index");
            }
            catch
            {
                return View("EditRotatie");
            }
        }

        // GET: Rotatie/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Rotatie/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}

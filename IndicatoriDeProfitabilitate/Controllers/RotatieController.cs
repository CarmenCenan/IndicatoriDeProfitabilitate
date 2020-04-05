using IndicatoriDeProfitabilitate.Models;
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
        [AllowAnonymous]
        public ActionResult Index()
        {
            List<Models.RotatieModel> rotatii = rotatieRepository.GetAllRotatii();
           
            return View("Index", rotatii);
        }
        

        // GET: Rotatie/Details/5
        [AllowAnonymous]
        public ActionResult Details(Guid id)
        {
            Models.RotatieModel rotatieModel = rotatieRepository.GetRotatieById(id);
            return View("RotatieDetails", rotatieModel);
        }

        // GET: Rotatie/Create
        [Authorize (Roles = "User, Admin")]
        public ActionResult Create()
        {
            return View("CreateRotatie");
        }

        // POST: Rotatie/Create
        [HttpPost]
        [Authorize(Roles = "User, Admin")]
        public ActionResult Create(FormCollection collection)
        {
            //try
            //{
                Models.RotatieModel rotatieModel = new Models.RotatieModel();
                UpdateModel(rotatieModel);
                rotatieRepository.InsertRotatie(rotatieModel);


                return RedirectToAction("Index");
            //}
            //catch
            //{
            //    return View("CreateRotatie");
            //}
        }
    
        // GET: Rotatie/Edit/5
        [Authorize(Roles = "User, Admin")]
        public ActionResult Edit(Guid id)
        {
            Models.RotatieModel rotatieModel = rotatieRepository.GetRotatieById(id);

            return View("EditRotatie", rotatieModel);
        }

        // POST: Rotatie/Edit/5
        [HttpPost]
        [Authorize(Roles = "User, Admin")]
        public ActionResult Edit(Guid id, FormCollection collection)
        {
            //try
            //{
                Models.RotatieModel rotatieModel = new Models.RotatieModel();
                UpdateModel(rotatieModel);
                rotatieRepository.UpdateRotatie(rotatieModel);
                return RedirectToAction("Index");
            //}
            //catch
            //{
            //    return View("EditRotatie");
            //}
        }

        // GET: Rotatie/Delete/5
        [Authorize(Roles = "Admin")]
        public ActionResult Delete(Guid id)
        {
            Models.RotatieModel rotatieModel = rotatieRepository.GetRotatieById(id);
            return View("DeleteRotatie", rotatieModel);
        }

        // POST: Rotatie/Delete/5
        [HttpPost]
        [Authorize(Roles = "Admin")]
        public ActionResult Delete(Guid id, FormCollection collection)
        {
            //try
            //{
                // TODO: Add delete logic here
                rotatieRepository.DeleteRotatie(id);
                return RedirectToAction("Index");
            //}
            //catch
            //{
            //    return View("DeleteRotatie");
            //}
        }
        
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IndicatoriDeProfitabilitate.Controllers
{
   
    
    public class CompanieController : Controller
    {
        private Repository.CompanieRepository companieRepository = new Repository.CompanieRepository();
        // GET: Companie
        public ActionResult Index()
        {
            List<Models.CompanieModel> companii =companieRepository.GetAllCompanii();
            return View("Index", companii);
        }

        // GET: Companie/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Companie/Create
        public ActionResult Create()
        {
            return View("CreateCompanie");
        }

        // POST: Companie/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                Models.CompanieModel companieModel = new Models.CompanieModel();
                UpdateModel(companieModel);
                companieRepository.InsertCompanie(companieModel);


                return RedirectToAction("Index");
            }
            catch
            {
                return View("CreateCompanie");
            }
        }

        // GET: Companie/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Companie/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Companie/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Companie/Delete/5
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

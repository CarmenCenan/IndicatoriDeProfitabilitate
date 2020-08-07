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
       [AllowAnonymous]
        public ActionResult Index()
        {
            List<Models.CompanieModel> companii =companieRepository.GetAllCompanii();
            return View("Index", companii);
        }

        // GET: Companie/Details/5
        [AllowAnonymous]
        public ActionResult Details(Guid id)
        {
            Models.CompanieModel companieModel = companieRepository.GetCompanieById(id);

            return View("DetailsCompanie", companieModel);
        }

        // GET: Companie/Create
        [Authorize (Roles = "User, Admin")]
        public ActionResult Create()
        {
            return View("CreateCompanie");
        }

        // POST: Companie/Create
        [Authorize (Roles ="User, Admin")]
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
        [Authorize (Roles = "User, Admin")]
        public ActionResult Edit(Guid id)
        {
            Models.CompanieModel companieModel = companieRepository.GetCompanieById(id);
            return View("EditCompanie", companieModel);
        }

        // POST: Companie/Edit/5
        [Authorize(Roles = "User, Admin")]
        [HttpPost]
        public ActionResult Edit(Guid id, FormCollection collection)
        {
            try
            {
                Models.CompanieModel companieModel = new Models.CompanieModel();
                UpdateModel(companieModel);
                companieRepository.UpdateCompanie(companieModel);

                return RedirectToAction("Index");
            }
            catch
            {
                return View("EditCompanie");
            }
        }

        // GET: Companie/Delete/5
        [Authorize(Roles = "Admin")]
        public ActionResult Delete(Guid id)
        {
            Models.CompanieModel companieModel = companieRepository.GetCompanieById(id);
            return View("DeleteCompanie", companieModel);
        }

        // POST: Companie/Delete/5
        [Authorize(Roles = "Admin")]
        [HttpPost]
        public ActionResult Delete(Guid id, FormCollection collection)
        {
            try
            {
                companieRepository.DeleteCompanie(id);

                return RedirectToAction("Index");
            }
            catch
            {
                return View("DeleteCompanie");
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IndicatoriDeProfitabilitate.Controllers
{
    public class PublicatController : Controller
    {
        private Repository.PublicatRepository publicatRepository = new Repository.PublicatRepository();
        // GET: Publicat
        public ActionResult Index()
        {
            List<Models.PublicatModel> publicatii = publicatRepository.GetAllPublicatii();
            return View("Index", publicatii);
        }

        // GET: Publicat/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Publicat/Create
        public ActionResult Create()
        {
            return View("CreatePublicat");
        }

        // POST: Publicat/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                Models.PublicatModel publicatModel = new Models.PublicatModel();
                UpdateModel(publicatModel);
                publicatRepository.InsertPublicat(publicatModel);

                return RedirectToAction("Index");
            }
            catch
            {
                return View("CreatePublicat");
            }
        }

        // GET: Publicat/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Publicat/Edit/5
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

        // GET: Publicat/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Publicat/Delete/5
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

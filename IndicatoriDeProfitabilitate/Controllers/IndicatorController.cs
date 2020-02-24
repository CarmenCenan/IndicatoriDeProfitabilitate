using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IndicatoriDeProfitabilitate.Controllers
{
    public class IndicatorController : Controller
    {
        private Repository.IndicatorRepository indicatorRepository = new Repository.IndicatorRepository();
        // GET: Indicator
        public ActionResult Index()
        {
            List<Models.IndicatorModel> indicatori = indicatorRepository.GetAllIndicatori();
            return View("Index", indicatori);
        }

        // GET: Indicator/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Indicator/Create
        public ActionResult Create()
        {
            return View("CreateIndicator");
        }

        // POST: Indicator/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                Models.IndicatorModel indicatorModel = new Models.IndicatorModel();
                UpdateModel(indicatorModel);
                indicatorRepository.InsertIndicator(indicatorModel);

                return RedirectToAction("Index");
            }
            catch
            {
                return View("CreateIndicator");
            }
        }

        // GET: Indicator/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Indicator/Edit/5
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

        // GET: Indicator/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Indicator/Delete/5
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

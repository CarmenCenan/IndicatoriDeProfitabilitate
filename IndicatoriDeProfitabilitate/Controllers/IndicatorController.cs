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
        public ActionResult Details(Guid id)
        {
            Models.IndicatorModel indicatorModel = indicatorRepository.GetIndicatorById(id);
            return View("IndicatorDetails", indicatorModel);
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
        public ActionResult Edit(Guid id)
        {
            Models.IndicatorModel indicatorModel = indicatorRepository.GetIndicatorById(id);
            return View("EditIndicator", indicatorModel);
        }

        // POST: Indicator/Edit/5
        [HttpPost]
        public ActionResult Edit(Guid id, FormCollection collection)
        {
            try
            {
                Models.IndicatorModel indicatorModel = new Models.IndicatorModel();
                UpdateModel(indicatorModel);
                indicatorRepository.UpdateIndicator(indicatorModel);

                return RedirectToAction("Index");
            }
            catch
            {
                return View("EditIndicator");
            }
        }

        // GET: Indicator/Delete/5
        public ActionResult Delete(Guid id)
        {
            Models.IndicatorModel indicatorModel = indicatorRepository.GetIndicatorById(id);
            return View("DeleteIndicator", indicatorModel);
        }

        // POST: Indicator/Delete/5
        [HttpPost]
        public ActionResult Delete(Guid id, FormCollection collection)
        {
            try
            {
                indicatorRepository.DeleteIndicator(id);

                return RedirectToAction("Index");
            }
            catch
            {
                return View("DeleteIndicator");
            }
        }
    }
}

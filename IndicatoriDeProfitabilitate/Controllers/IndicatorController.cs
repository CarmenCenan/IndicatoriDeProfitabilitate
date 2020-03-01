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
        [AllowAnonymous]
        public ActionResult Index()
        {
            List<Models.IndicatorModel> indicatori = indicatorRepository.GetAllIndicatori();
            return View("Index", indicatori);
        }

        // GET: Indicator/Details/5
        [AllowAnonymous]
        public ActionResult Details(Guid id)
        {
            Models.IndicatorModel indicatorModel = indicatorRepository.GetIndicatorById(id);
            return View("IndicatorDetails", indicatorModel);
        }

        // GET: Indicator/Create
        [Authorize(Roles ="User, Admin")]
        public ActionResult Create()
        {
            return View("CreateIndicator");
        }

        // POST: Indicator/Create
        [Authorize(Roles = "User, Admin")]
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                Models.IndicatorModel indicatorModel = new Models.IndicatorModel();
                UpdateModel(indicatorModel);
                if (User.Identity.IsAuthenticated) //daca avem utilizator logat
                {
                    indicatorModel.Denumire = User.Identity.Name + ": " + indicatorModel.Denumire;
                    indicatorModel.Descriere = indicatorModel.Descriere + "," + User.Identity.Name;
                }
                //
                indicatorRepository.InsertIndicator(indicatorModel);

                return RedirectToAction("Index");
            }
            catch
            {
                return View("CreateIndicator");
            }
        }

        // GET: Indicator/Edit/5
        [Authorize(Roles = "User, Admin")]
        public ActionResult Edit(Guid id)
        {
            Models.IndicatorModel indicatorModel = indicatorRepository.GetIndicatorById(id);
            return View("EditIndicator", indicatorModel);
        }

        // POST: Indicator/Edit/5
        [Authorize(Roles = "User, Admin")]
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
        [Authorize(Roles = "Admin")]
        public ActionResult Delete(Guid id)
        {
            Models.IndicatorModel indicatorModel = indicatorRepository.GetIndicatorById(id);
            return View("DeleteIndicator", indicatorModel);
        }

        // POST: Indicator/Delete/5
        [HttpPost]
        [Authorize(Roles = "Admin")]
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

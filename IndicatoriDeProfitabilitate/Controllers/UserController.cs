using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IndicatoriDeProfitabilitate.Controllers
{
    public class UserController : Controller
    {
        private Repository.UserRepository userRepository = new Repository.UserRepository();
        // GET: User
        public ActionResult Index()
        {
            List<Models.UserModel> users = userRepository.GetAllUsers();
            return View("Index", users);
        }

        // GET: User/Details/5
        [AllowAnonymous]
        public ActionResult Details(Guid id)
        {
            Models.UserModel userModel = userRepository.GetUserById(id);

            return View("DetailsUser", userModel);
        }

        // GET: User/Create
        [Authorize(Roles = "User, Admin")]
        public ActionResult Create()
        {
            return View("CreateUser");
        }

        // POST: User/Create
        [Authorize(Roles = "User, Admin")]
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                Models.UserModel userModel = new Models.UserModel();
                UpdateModel(userModel);
                userRepository.InsertUser(userModel);

                return RedirectToAction("Index");
            }
            catch
            {
                return View("CreateUser");
            }
        }

        // GET: User/Edit/5
        [Authorize(Roles = "User, Admin")]
        public ActionResult Edit(Guid id)
        {
            Models.UserModel userModel = userRepository.GetUserById(id);

            return View("EditUser", userModel);
        }

        // POST: User/Edit/5
        [Authorize(Roles = "User, Admin")]
        [HttpPost]
        public ActionResult Edit(Guid id, FormCollection collection)
        {
            try
            {
                Models.UserModel userModel = new Models.UserModel();
                UpdateModel(userModel);
                userRepository.UpdateUser(userModel);

                return RedirectToAction("Index");
            }
            catch
            {
                return View("EditUser");
            }
        }

        // GET: User/Delete/5
        [Authorize(Roles = "Admin")]
        public ActionResult Delete(Guid id)
        {
            Models.UserModel userModel = userRepository.GetUserById(id);
            return View("DeleteUser", userModel);
        }

        // POST: User/Delete/5
        [Authorize(Roles = "Admin")]
        [HttpPost]
        public ActionResult Delete(Guid id, FormCollection collection)
        {
            try
            {
                userRepository.DeleteUser(id);

                return RedirectToAction("Index");
            }
            catch
            {
                return View("DeleteUser");
            }
        }
    }
}

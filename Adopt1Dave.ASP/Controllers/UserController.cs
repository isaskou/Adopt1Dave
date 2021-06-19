using Adopt1Dave.ASP.Models;
using Adopt1Dave.ASP.Models.Forms;
using Adopt1Dave.ASP.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Adopt1Dave.ASP.Tools.Session;

namespace Adopt1Dave.ASP.Controllers
{
    public class UserController : Controller
    {
        IService<UserModel, RegisterForm> _service;

        public UserController(IService<UserModel, RegisterForm> service)
        {
            _service = service;
        }

        // GET: UserController
        public ActionResult Index()
        {
            return View();
        }

        // GET: UserController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: UserController/Create
        public ActionResult Register()
        {
            return View();
        }

        public ActionResult Profile()
        {
            return View();
        }

        // POST: UserController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(RegisterForm form)
        {
            if (ModelState.IsValid)
            {
                _service.Insert(form);
                TempData["success"] = "Bravo ! Vous êtes enregistré";
                //TODO
                //Faire la session
                HttpContext.Session.Set<bool>("IsLogged", true);
                //créer le formulaire Profile
                return RedirectToAction("Profile", "User", new { id = form.Id });
            }
            else
            {
                TempData["error"] = "Veuillez compléter tous les champs";
                return View(form);
            }

        }

        // GET: UserController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: UserController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: UserController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: UserController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}

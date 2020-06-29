using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MovieStore.Data.Entities;
using MovieStore.Services.Service.Interfaces;

namespace MovieStore.Controllers
{
    [Authorize(Roles = "admin, editor")]
    public class DirectorController : Controller
    {
        private readonly IDirectorService _directorService;

        public DirectorController(IDirectorService directorService)
        {
            _directorService = directorService;
        }


        // GET: Director
        public IActionResult Index()
        {
            var directorsList = _directorService.GetDirectors();
             return View(directorsList);
        }

        // GET: Director/Details/5
        public IActionResult Details(int id)
        {
            var director = _directorService.GetDidectorById(id);

            if (director == null)
            {
                return NotFound();
            }

            return View(director);
        }

        // GET: Director/Create
       [Authorize(Roles = "admin")]
        public IActionResult Create()
        {
            return View();
        }

        // POST: Director/Create
      [Authorize(Roles = "admin")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Director director)
        {
            if (ModelState.IsValid)
            {
                _directorService.Add(director);
                return RedirectToAction(nameof(Index));
            }
            return View(director);
        }


        [HttpPost]
        public JsonResult CreateDirectorAJAX(string name)
        {
            var director = new Director();

            if (name != "" || name != null)
            {
             director.Name = name;
            _directorService.Add(director);
            }
            return Json(director);
        }


        // GET: Director/Edit/5
        public IActionResult Edit(int id)
        {
            var director = _directorService.GetDidectorById(id);
            if (director == null)
            {
                return NotFound();
            }
            return View(director);
        }

        // POST: Director/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, Director director)
        {
            if (id != director.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _directorService.Edit(director);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                return RedirectToAction(nameof(Index));
            }
            return View(director);
        }

        // GET: Director/Delete/5
      [Authorize(Roles = "admin")]
        public IActionResult Delete(int id)
        {
            var director = _directorService.GetDidectorById(id);

            if (director == null)
            {
                return NotFound();
            }

            return View(director);
        }

        // POST: Director/Delete/5
       [Authorize(Roles = "admin")]
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmation(int id)
        {
            var director = _directorService.GetDidectorById(id);
            _directorService.Delete(director);

            return RedirectToAction(nameof(Index));
        }
    }
}
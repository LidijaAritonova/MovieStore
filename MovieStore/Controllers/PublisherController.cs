using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MovieStore.Data.Entities;
using MovieStore.Models;
using MovieStore.Services.Service.Interfaces;

namespace MovieStore.Controllers
{
    [Authorize(Roles = "admin, editor")]
    public class PublisherController : Controller
    {
        private readonly IPublisherService _publisherService;

        public PublisherController(IPublisherService publisherService)
        {
            _publisherService = publisherService;
        }
        // GET: Publisher
        public IActionResult Index()
        {
            var publishersList = _publisherService.GetPublishers();
            return View(publishersList);
        }

        // GET: Publisher/Details/5
        public IActionResult Details(int id)
        {
            var publisher = _publisherService.GetPublisherById(id);

            if (publisher == null)
            {
                return NotFound();
            }

            return View(publisher);
        }

        // GET: Publisher/Create
        [Authorize(Roles = "admin")]
        public IActionResult Create()
        {
            return View();
        }

        // POST: Publisher/Create
       [Authorize(Roles = "admin")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(PublisherViewModel publisherViewModel)
        {
            var publisher = new Publisher();

            if (ModelState.IsValid)
            {
                publisher.Name = publisherViewModel.Name;
                publisher.Country = publisherViewModel.Country;

                _publisherService.Add(publisher);

                return RedirectToAction(nameof(Index));
            }
            return View(publisher);
        }



        [HttpPost]
        public JsonResult CreatePublisherAJAX(string name, string country)
        {
            var publisher = new Publisher();

            if (name != "" || name != null && country != "" || country != null)
            {
                publisher.Name = name;
                publisher.Country = country;
                _publisherService.Add(publisher);
            }
            return Json(publisher);
        }

        // GET: Publisher/Edit/5
        public IActionResult Edit(int id)
        {
            var publisher = _publisherService.GetPublisherById(id);
            if (publisher == null)
            {
                return NotFound();
            }
            return View(publisher);
        }

        // POST: Publisher/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, Publisher publisher)
        {
            if (id != publisher.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _publisherService.Edit(publisher);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                return RedirectToAction(nameof(Index));
            }
            return View(publisher);
        }

        // GET: Publisher/Delete/5
         [Authorize(Roles = "admin")]
        public IActionResult Delete(int id)
        {
            var publisher = _publisherService.GetPublisherById(id);

            if (publisher == null)
            {
                return NotFound();
            }

            return View(publisher);
        }

        // POST: Publisher/Delete/5
        [Authorize(Roles = "admin")]
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
           var publisher = _publisherService.GetPublisherById(id);
           _publisherService.Delete(publisher);

            return RedirectToAction(nameof(Index));
        }
    }
}
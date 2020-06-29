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
    public class ProducerController : Controller
    {
        private readonly IProducerService _producerService;

        public ProducerController(IProducerService producerService)
        {
            _producerService = producerService;
        }

        // GET: Producer
        public IActionResult Index()
        {
            var producerList = _producerService.GetProducers();
            return View(producerList);
        }

        // GET: Producer/Details/5
        public IActionResult Details(int id)
        {
            var producer = _producerService.GetProducerById(id);

            if (producer == null)
            {
                return NotFound();
            }

            return View(producer);
        }

        // GET: Producer/Create
       [Authorize(Roles = "admin")]
        public IActionResult Create()
        {
            return View();
        }

        // POST: Producer/Create
      [Authorize(Roles = "admin")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Producer producer)
        {
            if (ModelState.IsValid)
            {
                _producerService.Add(producer);
                return RedirectToAction(nameof(Index));
            }
            return View(producer);
        }

        [HttpPost]
        public JsonResult CreateProducerAJAX(string name)
        {
            var producer = new Producer();

            if (name != "" || name != null)
            {
                producer.Name = name;
                _producerService.Add(producer);
            }
            return Json(producer);
        }

        // GET: Producer/Edit/5
        public IActionResult Edit(int id)
        {
            var producer = _producerService.GetProducerById(id);
            if (producer == null)
            {
                return NotFound();
            }
            return View(producer);
        }

        // POST: Producer/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Producer producer)
        {
            if (id != producer.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _producerService.Edit(producer);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                return RedirectToAction(nameof(Index));
            }
            return View(producer);
        }

        // GET: Producer/Delete/5
      [Authorize(Roles = "admin")]
        public IActionResult Delete(int id)
        {
            var producer = _producerService.GetProducerById(id);

            if (producer == null)
            {
                return NotFound();
            }

            return View(producer);
        }

        // POST: Producer/Delete/5
       [Authorize(Roles = "admin")]
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            var producer = _producerService.GetProducerById(id);
            _producerService.Delete(producer);

            return RedirectToAction(nameof(Index));
        }
    }
}
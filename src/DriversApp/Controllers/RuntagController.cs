using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DriversApp.Data;
using DriversApp.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace DriversApp.Controllers
{
    public class RuntagController : Controller
    {
        private readonly ApplicationDbContext _dbContext;
        public RuntagController(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public IActionResult Index()
        {
            var viewModel = new RuntagIndexViewModel();
            var models = _dbContext.Runtags.ToList().Select(x => new RuntagViewModel(x));
            if (models != null)
            {
                viewModel.Runtags = models;
            }

            return View(viewModel);
        }

        public IActionResult Create()
        {
            var viewModel = new RuntagViewModel();
            return View(viewModel);
        }
        [HttpPost]
        public IActionResult Create(RuntagViewModel viewModel)
        {
            if (ModelState.IsValid)
            {
                _dbContext.Runtags.Add(viewModel.Model);
                _dbContext.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(viewModel);
        }

        public IActionResult Edit(int id)
        {
            var model = _dbContext.Runtags.FirstOrDefault(x => x.Id.Equals(id));
            if (model == null)
            {
                NotFound();
            }
            var viewModel = new RuntagViewModel(model);
            return View(viewModel);
        }
        [HttpPost]
        public IActionResult Edit(int id, RuntagViewModel viewModel)
        {
            var model = _dbContext.Runtags.FirstOrDefault(x => x.Id.Equals(id));
            if (model != null)
            {
                model.Address = viewModel.Address;
                model.CustomerName = viewModel.CustomerName;
                model.Description = viewModel.Description;
                model.DueTime = viewModel.DueTime;
                model.Title = viewModel.Title;

                _dbContext.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(viewModel);
        }

        public IActionResult Delete(int id)
        {
            var model = _dbContext.Runtags.FirstOrDefault(x => x.Id.Equals(id));
            if (model != null)
            {
                _dbContext.Runtags.Remove(model);
                _dbContext.SaveChanges();
                return RedirectToAction("Index");
            }
            return RedirectToAction("Index");
        }

        public IActionResult Calendar(int id)
        {
            return View();
        }
    }
}
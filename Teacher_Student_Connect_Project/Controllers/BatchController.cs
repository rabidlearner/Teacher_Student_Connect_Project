using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Teacher_Student_Connect_Project.IRepository;
using Teacher_Student_Connect_Project.Models;
using Teacher_Student_Connect_Project.Repository;

namespace Teacher_Student_Connect_Project.Controllers
{
    public class BatchController:Controller
    {
        private readonly IBatchRepository batchRepository;

        public BatchController(IBatchRepository batchRepository)
        {
            this.batchRepository = batchRepository;
        }
        public IActionResult Index()
        {
            List<Batch> batches = new List<Batch>();
            batches = batchRepository.GetBatches();
            return View(batches);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Batch batch)
        {
            if (ModelState.IsValid)
            {
                batchRepository.PostBatches(batch);
                return RedirectToAction("Index");
            }
            return View(batch);
        }
    }
}

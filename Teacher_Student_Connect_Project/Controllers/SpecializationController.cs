using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Teacher_Student_Connect_Project.IRepository;
using Teacher_Student_Connect_Project.Models;

namespace Teacher_Student_Connect_Project.Controllers
{
    public class SpecializationController : Controller
    {
        private readonly ISpecializationRepository specializationRepository;

        public SpecializationController(ISpecializationRepository specializationRepository)
        {
            this.specializationRepository = specializationRepository;
        }
        public IActionResult Index()
        {
            List<Specialization> specializations = new List<Specialization>();
            specializations = specializationRepository.GetSpecializations();
            return View(specializations);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Specialization specialization)
        {
            if (ModelState.IsValid)
            {
                specializationRepository.PostSpecializations(specialization);
                return RedirectToAction("Index");
            }
            return View(specialization);
        }
    }
}

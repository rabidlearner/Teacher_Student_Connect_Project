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
    public class SubjectController:Controller
    {
        private readonly ISubjectRepository subjectRepository;

        public SubjectController(ISubjectRepository subjectRepository)
        {
            this.subjectRepository = subjectRepository;
        }
        public IActionResult Index()
        {
            List<Subject> subjects = new List<Subject>();
            subjects = subjectRepository.GetSubjects();
            return View(subjects);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Subject subject)
        {
            if (ModelState.IsValid)
            {
                subjectRepository.PostSubjects(subject);
                return RedirectToAction("Index");
            }
            return View(subject);
        }
    }
}

using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Teacher_Student_Connect_Project.Data;
using Teacher_Student_Connect_Project.IRepository;
using Teacher_Student_Connect_Project.Models;

namespace Teacher_Student_Connect_Project.Controllers
{
    public class AdminController:Controller
    {
        private readonly IAdminRepository adminRepository;
        
        public AdminController(IAdminRepository adminRepository)
        {
            this.adminRepository = adminRepository;
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Admin admin)
        {
            if (ModelState.IsValid)
            {
                adminRepository.PostAdmin(admin);
                return RedirectToAction("Index");
            }
            return View(admin);
        }

        public IActionResult AddDocuments()
        {
            Document document = new Document();
            document.Id = int.Parse(TempData["Id"].ToString());
            return View(document);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult AddDocuments(Document document)
        {
            if(ModelState.IsValid)
            {
                adminRepository.AddDocuments(document);
                return RedirectToAction("Index");
            }
            return View(document);
        }
        public IActionResult UpdateDocuments()
        {
            Document document = new Document();
            //document.Id = int.Parse(TempData["Id"].ToString());
            document = adminRepository.GetDocById(3);
            return View(document);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult UpdateDocuments(Document document)
        {
            if (ModelState.IsValid)
            {
                adminRepository.UpdateDocuments(document);
                return RedirectToAction("Index");
            }
            return View(document);
        }
    }
}

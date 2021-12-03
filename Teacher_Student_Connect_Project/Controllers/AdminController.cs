using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Teacher_Student_Connect_Project.Data;
using Teacher_Student_Connect_Project.IControllerServices;
using Teacher_Student_Connect_Project.IRepository;
using Teacher_Student_Connect_Project.Models;
using Teacher_Student_Connect_Project.ViewModels;

namespace Teacher_Student_Connect_Project.Controllers
{
    public class AdminController:Controller
    {
        private readonly IAdminRepository adminRepository;
        private readonly IAdminServices adminServices;
        
        public AdminController(IAdminRepository adminRepository,IAdminServices adminServices)
        {
            this.adminRepository = adminRepository;
            this.adminServices = adminServices;
        }
        public IActionResult Index()
        {
            try
            {
                List<AdminDataViewModel> adminDataViewModels = new List<AdminDataViewModel>();
                adminDataViewModels = adminServices.GetAdmins(int.Parse(TempData["Id"].ToString()));
                return View(adminDataViewModels);
            }
            catch (Exception)
            {
                return RedirectToAction("Logout", "Account");
            }
        }
        public IActionResult Create()
        {
            AdminViewModel adminViewModel = new AdminViewModel();
            adminViewModel = adminServices.Create();
            //adminViewModel.UserId = int.Parse(TempData["Id"].ToString());
            return View(adminViewModel);
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
          /*  Document document = new Document();
           document.Id = int.Parse(TempData["Id"].ToString());
           return View(document);*/
            try
            {
                AddDocuments addDocuments = new AddDocuments();
                // addDocuments = adminservices.GenerateAvailability();
                addDocuments.SubjectList = adminRepository.GetSubjectList();
                addDocuments.Id= int.Parse(TempData["Id"].ToString());
                return View(addDocuments);
            }
            catch (Exception)
            {
                return RedirectToAction("Logout", "Account");
            }
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult AddDocuments(AddDocuments addDocuments)
        {
            if(ModelState.IsValid)
            {
                // adminrepository.AddDocuments(addDocuments);
                adminServices.PostAddDocuments(addDocuments);
                return RedirectToAction("Index");
            }
            return View(addDocuments);
        }
        public IActionResult UpdateDocuments()
        {
            Document document = new Document();
            //document.Id = int.Parse(TempData["Id"].ToString());
            document = adminRepository.GetDocById(3);
            return View(document);
        }
        [HttpGet]
        
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

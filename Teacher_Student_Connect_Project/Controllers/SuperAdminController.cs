using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Teacher_Student_Connect_Project.IRepository;

namespace Teacher_Student_Connect_Project.Controllers
{
    public class SuperAdminController : Controller
    {
        private readonly IAdminRepository adminRepository;

        public SuperAdminController(IAdminRepository adminRepository)
        {
            this.adminRepository = adminRepository;
        }
        /*public IActionResult ApproveHospital(int id)
        {
            RegisterViewModel user = new RegisterViewModel();
            user = adminControllerService.UserFromHospital(id);
            return View("Register", user);
        }
        [HttpPost]

        public IActionResult ApproveHospital(RegisterViewModel registerViewModel)
        {
            if (ModelState.IsValid)
            {
                accountControllerService.CreateUser(registerViewModel);

                return RedirectToAction("Index", "Admin");
            }
            return View(registerViewModel);
        }*/
    }
}

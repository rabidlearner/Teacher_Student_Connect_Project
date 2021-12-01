using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Teacher_Student_Connect_Project.IControllerServices;
using Teacher_Student_Connect_Project.IRepository;
using Teacher_Student_Connect_Project.ViewModels;

namespace Teacher_Student_Connect_Project.Controllers
{
    public class StudentController : Controller
    {
        private readonly IStudentRepository studentRepository;
        private readonly IStudentServices studentServices;

        public StudentController(IStudentRepository studentRepository, IStudentServices studentServices)
        {
            this.studentRepository = studentRepository;
            this.studentServices = studentServices;
        }
        public IActionResult Index()
        {
            try
            {
                List<StudentDataViewModel> studentDataViewModels = new List<StudentDataViewModel>();
                studentDataViewModels = studentServices.GetStudents(int.Parse(TempData["Id"].ToString()));
                return View(studentDataViewModels);
            }
            catch (Exception)
            {
                return RedirectToAction("Logout", "Account");
            }
        }
        
        public IActionResult Create()
        {
            StudentViewModel studentViewModel = new StudentViewModel();
            studentViewModel = studentServices.Create();
            studentViewModel.UserId= int.Parse(TempData["Id"].ToString());
            return View(studentViewModel);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(StudentViewModel student)
        {
            if (ModelState.IsValid)
            {

                studentServices.PostStudent(student);
                return RedirectToAction("Index");
            }
            else
            {
                return View(student);
            }

        }
    }
}

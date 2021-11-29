﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Teacher_Student_Connect_Project.IControllerServices;
using Teacher_Student_Connect_Project.IRepository;
using Teacher_Student_Connect_Project.ViewModels;

namespace Teacher_Student_Connect_Project.Controllers
{
    public class TeacherController : Controller
    {
        private readonly ITeacherRepository teacherRepository;
        private readonly ITeacherServices teacherServices;

        public TeacherController(ITeacherRepository teacherRepository, ITeacherServices teacherServices)
        {
            this.teacherRepository = teacherRepository;
            this.teacherServices = teacherServices;
        }
        public IActionResult Index()
        {
            List<TeacherDataViewModel> teachers = new List<TeacherDataViewModel>();
            teachers = teacherServices.GetTeachers();
            return View(teachers);
        }
        public IActionResult Create()
        {
            TeacherViewModel teacherViewModel = new TeacherViewModel();
            teacherViewModel = teacherServices.Create();
            return View(teacherViewModel);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(TeacherViewModel teacher)
        {
            if (ModelState.IsValid)
            {

                teacherServices.PostTeacher(teacher);
                return RedirectToAction("Index");
            }
            else
            {
                return View(teacher);
            }

        }
    }
}

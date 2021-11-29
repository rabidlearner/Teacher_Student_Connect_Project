using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Teacher_Student_Connect_Project.IControllerServices;
using Teacher_Student_Connect_Project.IRepository;
using Teacher_Student_Connect_Project.Models;
using Teacher_Student_Connect_Project.ViewModels;

namespace Teacher_Student_Connect_Project.ControllerServices
{
    public class TeacherServices : ITeacherServices
    {
        private readonly ISubjectRepository subjectRepository;
        private readonly ITeacherRepository teacherRepository;
        private readonly IUserRepository userRepository;
        private readonly IMapper mapper;

        public TeacherServices(ISubjectRepository subjectRepository, ITeacherRepository teacherRepository, IMapper mapper, IUserRepository userRepository)
        {
            this.subjectRepository = subjectRepository;
            this.teacherRepository = teacherRepository;
            this.userRepository = userRepository;
            this.mapper = mapper;
        }
        public TeacherViewModel Create()
        {
            TeacherViewModel teacherViewModel = new TeacherViewModel();
            teacherViewModel.Subject = subjectRepository.GetSubjects();
            teacherViewModel.User = userRepository.GetUsers();

            return teacherViewModel;
        }

        public List<TeacherDataViewModel> GetTeachers()
        {
            List<TeacherDataViewModel> teacherDataViewModels = new List<TeacherDataViewModel>();
            List<Teacher> teachers = new List<Teacher>();
            teachers = teacherRepository.GetTeachers();
            List<Subject> subjects = new List<Subject>();
            subjects = subjectRepository.GetSubjects();
            List<User> users = new List<User>();


            var result = (from teacher in teachers
                          join user in users
                          on teacher.UserId equals user.Id
                          join subject in subjects
                          on teacher.SubjectId equals subject.Id
                          select new
                          {
                              Id = teacher.Id,
                              FirstName = user.FirstName,
                              LastName = user.LastName,
                              Dob = user.Dob,
                              Gender = user.Gender,
                              PhoneNumber = user.PhoneNumber,
                              Website = user.Email,
                              SubjectId = teacher.SubjectId,
                          }
                        );
            foreach (var teacher in result)
            {
                TeacherDataViewModel teacherData = new TeacherDataViewModel()
                {
                    Id = teacher.Id,
                    FirstName = teacher.FirstName,
                    LastName = teacher.LastName,
                    Dob = teacher.Dob,
                    Gender = teacher.Gender,
                    PhoneNumber = teacher.PhoneNumber,
                    Website = teacher.Website,
                    SubjectId = teacher.SubjectId,
                };
                teacherDataViewModels.Add(teacherData);

            }
            return teacherDataViewModels;
        }

        public void PostTeacher(TeacherViewModel teacherViewModel)
        {
            Teacher teacher = new Teacher();

            teacher = mapper.Map<Teacher>(teacherViewModel);
            teacherRepository.PostTeacher(teacher);
        }
    }
}

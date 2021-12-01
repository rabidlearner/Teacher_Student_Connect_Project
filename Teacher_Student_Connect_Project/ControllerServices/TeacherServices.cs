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
        private readonly ISpecializationRepository specializationRepository;
        private readonly IUserRepository userRepository;
        private readonly IMapper mapper;

        public TeacherServices(ISubjectRepository subjectRepository, ITeacherRepository teacherRepository, IMapper mapper, IUserRepository userRepository, ISpecializationRepository specializationRepository)
        {
            this.subjectRepository = subjectRepository;
            this.teacherRepository = teacherRepository;
            this.specializationRepository = specializationRepository;
            this.userRepository = userRepository;
            this.mapper = mapper;
        }
        public TeacherViewModel Create()
        {
            TeacherViewModel teacherViewModel = new TeacherViewModel();
            teacherViewModel.Subject = subjectRepository.GetSubjects();
            teacherViewModel.Specialization = specializationRepository.GetSpecializations();

            return teacherViewModel;
        }

        public List<TeacherDataViewModel> GetTeachers(int id)
        {
            List<TeacherDataViewModel> teacherDataViewModels = new List<TeacherDataViewModel>();
            Teacher teachers = new Teacher();
            teachers = teacherRepository.GetTeacherByUserId(id);
            Subject subjects = new Subject();
            subjects = subjectRepository.GetSubject(teachers.SubjectId);
            Specialization specializations = new Specialization();
            specializations = specializationRepository.GetSpecialization(teachers.SpecializationId);
            User users = new User();
            users = userRepository.GetUserById(id);

            TeacherDataViewModel teacherData = new TeacherDataViewModel()
            {
                Id = teachers.Id,
                FirstName = users.FirstName,
                LastName = users.LastName,
                Dob = users.Dob,
                Gender = users.Gender,
                PhoneNumber = users.PhoneNumber,
                Website = users.Email,
                SubjectName = subjects.Subject_Name,
                SpecializationName = specializations.Name,
                PriorExperience = teachers.PriorExperience,
                DateofJoining = teachers.DateOfJoining
            };
            teacherDataViewModels.Add(teacherData);
            return teacherDataViewModels;

            /*var result = (from teacher in teachers
                          join user in users
                          on teacher.UserId equals user.Id
                          join subject in subjects
                          on teacher.SubjectId equals subject.Id
                          join specialization in specializations
                          on teacher.SpecializationId equals specialization.Id
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
                              SpecializationId = teacher.SpecializationId
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
                    SpecializationId = teacher.SpecializationId
                };
                teacherDataViewModels.Add(teacherData);

            }
            return teacherDataViewModels;*/
        }

        public void PostTeacher(TeacherViewModel teacherViewModel)
        {
            Teacher teacher = new Teacher();

            teacher = mapper.Map<Teacher>(teacherViewModel);
            teacherRepository.PostTeacher(teacher);
        }
    }
}

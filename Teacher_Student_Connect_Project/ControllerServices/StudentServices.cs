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
    public class StudentServices : IStudentServices
    {
        private readonly IBatchRepository batchRepository;
        private readonly IStudentRepository studentRepository;
        private readonly IUserRepository userRepository;
        private readonly IMapper mapper;

        public StudentServices(IBatchRepository batchRepository, IStudentRepository studentRepository, IMapper mapper, IUserRepository userRepository)
        {
            this.batchRepository = batchRepository;
            this.studentRepository = studentRepository;
            this.userRepository = userRepository;
            this.mapper = mapper;
        }
        public StudentViewModel Create()
        {
            StudentViewModel studentViewModel = new StudentViewModel();
            studentViewModel.Batch = batchRepository.GetBatches();
            studentViewModel.User = userRepository.GetUsers();

            return studentViewModel;
        }

        public List<StudentDataViewModel> GetStudents()
        {
            List<StudentDataViewModel> studentDataViewModels = new List<StudentDataViewModel>();
            List<Student> students = new List<Student>();
            students = studentRepository.GetStudents();
            List<Batch> batches = new List<Batch>();
            batches = batchRepository.GetBatches();
            List<User> users = new List<User>();


            var result = (from student in students
                          join user in users
                          on student.UserId equals user.Id
                          join batch in batches
                          on student.BatchId equals batch.Id
                          select new
                          {
                              Id = student.Id,
                              FirstName = user.FirstName,
                              LastName = user.LastName,
                              Dob = user.Dob,
                              Gender = user.Gender,
                              PhoneNumber = user.PhoneNumber,
                              UserId = user.UserId,
                              Website = user.Email,
                              Batch = batch.Batch_Number,
                              BatchYear= batch.Year
                          }
                        );
            foreach (var student in result)
            {
                StudentDataViewModel studentData = new StudentDataViewModel()
                {
                    Id = student.Id,
                    FirstName = user.FirstName,
                    LastName = user.LastName,
                    Dob = user.Dob,
                    Gender = user.Gender,
                    PhoneNumber = user.PhoneNumber,
                    UserId = user.UserId,
                    Website = user.Email,
                    Batch = batch.Batch_Number,
                    BatchYear = batch.Year
                };
                studentDataViewModels.Add(studentData);

            }
            return studentDataViewModels;
        }

        public void PostStudent(StudentViewModel studentViewModel)
        {
            clinicViewModel.FacilitiesAvailable = String.Join(", ", clinicViewModel.FacilitiesSelected);
            Student student = new Student();

            student = mapper.Map<Student>(studentViewModel);
            studentRepository.PostStudent(student);
        }
    }
}

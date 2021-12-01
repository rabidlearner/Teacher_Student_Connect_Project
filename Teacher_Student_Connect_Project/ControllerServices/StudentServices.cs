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

            return studentViewModel;
        }

        public List<StudentDataViewModel> GetStudents(int id)
        {
            List<StudentDataViewModel> studentDataViewModels = new List<StudentDataViewModel>();
            Student students = new Student();
            students = studentRepository.GetStudentByUserId(id);
            Batch batches = new Batch();
            batches = batchRepository.GetBatch(students.BatchId);
            User users = new User();
            users= userRepository.GetUserById(id);

            StudentDataViewModel studentData = new StudentDataViewModel()
            {
                Id = students.Id,
                FirstName = users.FirstName,
                LastName = users.LastName,
                Dob = users.Dob,
                Gender = users.Gender,
                PhoneNumber = users.PhoneNumber,
                Website = users.Email,
                BatchYear = batches.Year
            };
            studentDataViewModels.Add(studentData);
            return studentDataViewModels;

            /*var result = (from student in students
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
                              Website = user.Email,
                              BatchYear= batch.Year
                          }
                        );
            foreach (var student in result)
            {
                StudentDataViewModel studentData = new StudentDataViewModel()
                {
                    Id = student.Id,
                    FirstName = student.FirstName,
                    LastName = student.LastName,
                    Dob = student.Dob,
                    Gender = student.Gender,
                    PhoneNumber = student.PhoneNumber,
                    Website = student.Website,
                    BatchYear = student.BatchYear
                };
                studentDataViewModels.Add(studentData);

            }
            return studentDataViewModels;*/
        }

        public void PostStudent(StudentViewModel studentViewModel)
        {
            Student student = new Student();

            student = mapper.Map<Student>(studentViewModel);
            studentRepository.PostStudent(student);
        }
    }
}

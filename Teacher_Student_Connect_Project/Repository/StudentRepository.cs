using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Teacher_Student_Connect_Project.Data;
using Teacher_Student_Connect_Project.IRepository;
using Teacher_Student_Connect_Project.Models;
using Teacher_Student_Connect_Project.ViewModels;

namespace Teacher_Student_Connect_Project.Repository
{
    public class StudentRepository : IStudentRepository
    {
        private readonly IMapper mapper;
        private readonly ApplicationDbContext dbContext;

        public StudentRepository(IMapper mapper, ApplicationDbContext dbContext)
        {
            this.mapper = mapper;
            this.dbContext = dbContext;
        }

        public Student GetStudent(int Id)
        {
            Student student = new Student();
            student = dbContext.Students.FirstOrDefault(m => m.Id == Id);
            return student;
        }

        public Student GetStudentByUserId(int Id)
        {
            Student student = new Student();
            student = dbContext.Students.FirstOrDefault(m => m.UserId == Id);
            return student;
        }

        public List<Student> GetStudents()
        {
            List<Student> students = new List<Student>();
            students = dbContext.Students.ToList();
            return students;
        }

        public void PostStudent(Student Student)
        {
            dbContext.Students.Add(Student);
            dbContext.SaveChanges();
        }
    }
}

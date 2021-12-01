using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Teacher_Student_Connect_Project.Data;
using Teacher_Student_Connect_Project.IRepository;
using Teacher_Student_Connect_Project.Models;

namespace Teacher_Student_Connect_Project.Repository
{
    public class TeacherRepository : ITeacherRepository
    {
        private readonly IMapper mapper;
        private readonly ApplicationDbContext dbContext;

        public TeacherRepository(IMapper mapper, ApplicationDbContext dbContext)
        {
            this.mapper = mapper;
            this.dbContext = dbContext;
        }

        public Teacher GetTeacher(int Id)
        {
            Teacher teacher = new Teacher();
            teacher = dbContext.Teachers.FirstOrDefault(m => m.Id == Id);
            return teacher;
        }

        public Teacher GetTeacherByUserId(int Id)
        {
            Teacher teacher = new Teacher();
            teacher = dbContext.Teachers.FirstOrDefault(m => m.UserId == Id);
            return teacher;
        }

        public List<Teacher> GetTeachers()
        {
            List<Teacher> teachers = new List<Teacher>();
            teachers = dbContext.Teachers.ToList();
            return teachers;
        }

        public void PostTeacher(Teacher Teacher)
        {
            dbContext.Teachers.Add(Teacher);
            dbContext.SaveChanges();
        }
    }
}

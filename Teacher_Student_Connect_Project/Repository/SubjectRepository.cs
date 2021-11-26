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
    public class SubjectRepository:ISubjectRepository
    {
        private readonly IMapper mapper;
        private readonly ApplicationDbContext dbContext;
        public SubjectRepository(IMapper mapper,ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
            this.mapper = mapper;
        }
        public List<Subject> GetSubjects()
        {
            List<Subject> subjects = new List<Subject>();
            subjects = dbContext.Subjects.ToList();
            return subjects;

        }
        public Subject GetSubjects(int id)
        {
            Subject subject = new Subject();
            subject = dbContext.Subjects.FirstOrDefault(m => m.Id == id);
            return subject;
        }
        public void PostSubjects(Subject subject)
        {
            dbContext.Subjects.Add(subject);
            dbContext.SaveChanges();
        }
    }
}

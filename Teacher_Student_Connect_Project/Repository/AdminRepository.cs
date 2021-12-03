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
    public class AdminRepository: IAdminRepository 
    {
        private readonly IMapper mapper;
        private readonly ApplicationDbContext dbContext;
        public AdminRepository(IMapper mapper,ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
            this.mapper = mapper;

        }
        public Admin GetAdmin(int id)
        {
            Admin admin = new Admin();
            admin = dbContext.Admins.FirstOrDefault(m => m.Id == id);
            return admin;
        }
        public void PostAdmin(Admin admin)
        {
            dbContext.Admins.Add(admin);
            dbContext.SaveChanges();
        }
        public void AddDocuments(Document document)
        {
            dbContext.Documents.Add(document);
            dbContext.SaveChanges();
        }
        public void UpdateDocuments(Document document)
        {
            dbContext.Documents.Add(document);
            dbContext.SaveChanges();
        }
        public Document GetDocById(int id)
        {
            Document document = new Document();
            document = dbContext.Documents.FirstOrDefault(m => m.Id == id);
            return document;
        }
        public Admin GetAdminByUserId(int Id)
        {
            Admin admin = new Admin();
            admin = dbContext.Admins.FirstOrDefault(m => m.UserId == Id);
            return admin;
        }
        public void PostAddDocuments(Document document)
        {
            //dbContext.Subjects.ToList();
            dbContext.Documents.Add(document);
            dbContext.SaveChanges();
        }
        public List<Subject> GetSubjectList()
        {
            List<Subject> subjects = new List<Subject>(); 
            dbContext.Subjects.ToList();
            return subjects;
        }
    }
}

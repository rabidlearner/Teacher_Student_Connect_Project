using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Teacher_Student_Connect_Project.Models;

namespace Teacher_Student_Connect_Project.IRepository
{
    public interface IAdminRepository
    {
        Admin GetAdmin(int Id);
        void PostAdmin(Admin Admin);
        void AddDocuments(Document document);
        void UpdateDocuments(Document document);
        Document GetDocById(int id);
        public Admin GetAdminByUserId(int id);
        public void PostAddDocuments(Document document);
        public List<Subject> GetSubjectList();
    }
}

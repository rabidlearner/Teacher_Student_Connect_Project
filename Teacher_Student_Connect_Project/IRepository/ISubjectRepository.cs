using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Teacher_Student_Connect_Project.Models;

namespace Teacher_Student_Connect_Project.IRepository
{
    public interface ISubjectRepository
    {
        List<Subject> GetSubjects();
        Subject GetSubject(int id);
        void PostSubjects(Subject subject); 
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Teacher_Student_Connect_Project.Models;

namespace Teacher_Student_Connect_Project.ViewModels
{
    public class AddDocuments
    {
        public AddDocuments()
        {
            List<Subject> SubjectList = new List<Subject>();
            {
                new Subject { Id = 1, Subject_Name = "Marketing" }; 
                new Subject { Id = 2, Subject_Name = "International Relations" };
                new Subject { Id = 3, Subject_Name = "Human Resources Management" };
                new Subject { Id = 4, Subject_Name = "Commerce" };
                new Subject { Id = 5, Subject_Name = "Economics" };
                new Subject { Id = 6, Subject_Name = "Bookkeeping" };
                new Subject { Id = 7, Subject_Name = "Accounting" };
                new Subject { Id = 8, Subject_Name = "Banking & Fianace" };
                new Subject { Id = 9, Subject_Name = "Bussiness Administration and Management" };
                new Subject { Id = 10, Subject_Name = "Entrepreneurship" };
                new Subject { Id = 11, Subject_Name = "Digital and Social Media Marketing" };
                new Subject { Id = 12, Subject_Name = "Bussiness Communication" };
                new Subject { Id = 13, Subject_Name = "Foriegn Exchange Trading" };
            };
           

        }
        public int Id { get; set; }
        public string Description { get; set; }
        public int SubjectId { get; set; }
        public List<Subject> SubjectList { get; set; }
        public Subject Subject { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string CompetencyLevel { get; set; }
        public string IntendedAudience { get; set; }
        public string Attachment { get; set; }
    }
}

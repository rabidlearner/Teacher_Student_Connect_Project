using Teacher_Student_Connect_Project.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Teacher_Student_Connect_Project.Models
{
    public class Search
    {
        public int Id { get; set; }
        public string Subjects { get; set; }
        public string Documents { get; set; }

        
       // public List<Subject> Subjects { get; set; }
        //public List<Document> Documents { get; set; }
    }
}
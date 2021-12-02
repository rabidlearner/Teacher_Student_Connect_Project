using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Teacher_Student_Connect_Project.Models;

namespace Teacher_Student_Connect_Project.ViewModels
{
    public class AdminViewModel
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
        public int DocumnetId { get; set; }
        //public Document Document { get; set; }
        public List<Document> DocumentList { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Teacher_Student_Connect_Project.Models
{
    public class Admin
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
        public int DocumnetId { get; set; }
        public Document Document { get; set; }
        public List<Document> DocumentList { get; set; }


    }
}

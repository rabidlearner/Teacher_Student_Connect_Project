using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Teacher_Student_Connect_Project.Models
{
    public class Student
    {
        public int Id { get; set; }
        public int BatchId { get; set; }
        public Batch Batch { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Teacher_Student_Connect_Project.Models
{
    public class Teacher
    {
        public int Id { get; set; }
        public int SubjectId { get; set; }
        public Subject Subject { get; set; }
        public int DateOfJoining { get; set; }
        public int PriorExperience { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
        public int SpecializationId { get; set; }
        public Specialization Specialization { get; set; }

    }
}

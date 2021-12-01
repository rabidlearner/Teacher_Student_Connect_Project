using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Teacher_Student_Connect_Project.Models;

namespace Teacher_Student_Connect_Project.ViewModels
{
    public class TeacherViewModel
    {
        public int Id { get; set; }
        public int SubjectId { get; set; }

        public List<Subject> Subject { get; set; }

        [Required(ErrorMessage = "Date of joining is Mandatory")]
        [Display(Name = "Date of Joining")]
        public DateTime DateofJoining { get; set; }

        [Display(Name = "Prior Experience")]
        public int PriorExperience { get; set; }

        public int UserId { get; set; }
        public List<User> User { get; set; }

        public int SpecializationId { get; set; }
        public List<Specialization> Specialization { get; set; }

    }
}

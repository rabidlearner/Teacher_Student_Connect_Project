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

        public IList<Subject> Subject { get; set; }

        [Required(ErrorMessage = "Date of birth is Mandatory")]
        [Display(Name = "Date of Birth")]
        [DataType(DataType.Date, ErrorMessage = "Please Enter a Valid Date")]
        public int DateofJoining { get; set; }

        [Display(Name = "Prior Experience")]
        [DataType(DataType.Date, ErrorMessage = "Please Enter a Valid number in months")]
        public int PriorExperience { get; set; }

        public int UserId { get; set; }
        public User User { get; set; }

    }
}

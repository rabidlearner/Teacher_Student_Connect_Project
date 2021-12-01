using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Teacher_Student_Connect_Project.Models;

namespace Teacher_Student_Connect_Project.ViewModels
{
    public class TeacherDataViewModel
    {
        public int Id { get; set; }
        public int SubjectId { get; set; }

        public List<Subject> Subject { get; set; }

        [Required(ErrorMessage = "Date of joining is Mandatory")]
        [Display(Name = "Date of Joining")]
        [DataType(DataType.Date, ErrorMessage = "Please Enter a Valid Date")]
        public int DateofJoining { get; set; }

        [Display(Name = "Prior Experience")]
        public int PriorExperience { get; set; }

        //Experience = Math.Abs(12 * (DateofJoining.Year - DateTime.Now.Year) + DateOfJoining.Month - DateTime.Now.Month);

        public int UserId { get; set; }
        public List<User> User { get; set; }

        public int SpecializationId { get; set; }
        public List<Specialization> Specialization { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime Dob { get; set; }
        public string Gender { get; set; }
        public string PhoneNumber { get; set; }
        public string Subject_Name { get; set; }
        public string Specialization_Name { get; set; }
        public string Website { get; set; }
    }
}

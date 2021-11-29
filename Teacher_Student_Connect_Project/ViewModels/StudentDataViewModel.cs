using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Teacher_Student_Connect_Project.Models;

namespace Teacher_Student_Connect_Project.ViewModels
{
    public class StudentDataViewModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Please choose a batch")]
        [Display(Name = "Batch")]
        public int BatchId { get; set; }
        public List<Batch> Batch { get; set; }
        public int UserId { get; set; }
        public List<User> User { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime Dob { get; set; }
        public string Gender { get; set; }
        public string PhoneNumber { get; set; }
        public string Website { get; set; }
        public int BatchYear { get; set; }

    }
}

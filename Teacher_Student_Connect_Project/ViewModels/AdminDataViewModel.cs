using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Teacher_Student_Connect_Project.ViewModels
{
    public class AdminDataViewModel
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime Dob { get; set; }
        public string Gender { get; set; }
        public string PhoneNumber { get; set; }
        public int UserId { get; set; }
        public string Website { get; set; }
    }
}

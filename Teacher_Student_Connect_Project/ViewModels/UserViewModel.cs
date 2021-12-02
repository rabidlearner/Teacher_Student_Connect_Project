﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Teacher_Student_Connect_Project.ViewModels
{
    public class UserViewModel
    {

        public int Id { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        [DataType(DataType.Date)]
        public DateTime Dob { get; set; }
        [Required]
        public string Gender { get; set; }
        [Required]
        [DataType(DataType.PhoneNumber)]
        public string PhoneNumber { get; set; }

        public string UserId { get; set; }
        [DataType(DataType.Password)]
        [Required]
        public string Password { get; set; }
        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [Required]
        public string Role { get; set; }
        [Required]
        [Display(Name = "What is your mother's maiden name?")]
        public string Answer1 { get; set; }
        [Required]
        [Display(Name = "What is your home city name?")]
        public string Answer2 { get; set; }
        [Required]
        [Display(Name = "What is your pet's name?")]
        public string Answer3 { get; set; }
        public bool IsApproved { get; set; }

    }
}

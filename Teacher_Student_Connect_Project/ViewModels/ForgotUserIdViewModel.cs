﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Teacher_Student_Connect_Project.ViewModels
{
    public class ForgotUserIdViewModel
    {
        [Required]
        [DataType(DataType.PhoneNumber)]
        public string PhoneNumber { get; set; }
        [Required]
        [Display(Name = "What is your mother's maiden name?")]
        public string Answer1 { get; set; }
        [Required]
        [Display(Name = "What is your home city name?")]
        public string Answer2 { get; set; }
        [Required]
        [Display(Name = "What is your pet's name?")]
        public string Answer3 { get; set; }
    }
}

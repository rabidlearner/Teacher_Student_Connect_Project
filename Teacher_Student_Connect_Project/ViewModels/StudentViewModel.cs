using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Teacher_Student_Connect_Project.Models;

namespace Teacher_Student_Connect_Project.ViewModels
{
    public class StudentViewModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage="Please choose a batch")]
        [Display(Name ="Batch")]
        public int BatchId { get; set; }
        public Batch Batch { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
    }
}

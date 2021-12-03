using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Teacher_Student_Connect_Project.Models;

namespace Teacher_Student_Connect_Project.ViewModels
{
    public class DocumentDataViewModel
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public int SubjectId { get; set; }
        [Required]
        public Subject Subject { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string Author { get; set; }
        [Required]
        public string CompetencyLevel { get; set; }
        [Required]
        public string IntendedAudience { get; set; }
        [Required]
        public IFormFile Attachment { get; set; }
    }
}

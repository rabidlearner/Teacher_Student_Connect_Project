using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Teacher_Student_Connect_Project.Models
{
    public class Document
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public int SubjectId { get; set; }
        public List<Subject> Subject { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string CompetencyLevel { get; set; }
        public string IntendedAudience { get; set; }
        public string AttachmentLocale { get; set; }
    }
}

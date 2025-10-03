using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P01_StudentSystem.FristEF.Models
{
    public class Homework
    {
        public enum ContentTypes
        {
            Application,
            Pdf,
            Zip
        }
        public int HomeworkId { get; set; }

        [Unicode(false)]
        public string Content { get; set; }
        public ContentTypes ContentType { get; set; }  
        public DateTime SubmissionTime { get; set; }
        public int StudentId { get; set; }
        public Student Student { get; set; }
        public int CourseId { get; set; }
        public Course Course { get; set; }
    }
}

using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P01_StudentSystem.FristEF.Models
{
    public class Student
    {
        public int StudentId { get; set; }
        [MaxLength(100)]
        [Unicode(true)]
        public string Name { get; set; }
        [Column(TypeName = "char(10)")]
        [Unicode(false)]
        public string? PhoneNumber { get; set; }
        public DateTime RegisteredOn { get; set; }
        public string? Birthday { get; set; }
        public List<StudentCourse> StudentCourses { get; set; } = new List<StudentCourse>();
        public List<Homework> Homeworks { get; set; } = new List<Homework>();
    }
}

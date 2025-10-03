using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace P01_StudentSystem.FristEF.Models
{
    public class Resource
    {
        public enum ResourceTypes
        {
            Video,
            Presentation,
            Document,
            Other
        }
        public int ResourceId { get; set; }
        [MaxLength(50)]
        public string Name { get; set; }
        [Unicode(false)]
        public string Url { get; set; }
        public ResourceTypes ResourceType { get; set; }   
        public int CourseId { get; set; }
        public Course Course { get; set; }
    }
}

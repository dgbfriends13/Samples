using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Samples.Models
{

    [MetadataType(typeof(StudentMetadata))]
    public partial class Student
    {
        
    }
    public class StudentMetadata
    {
        public int StudentID { get; set; }
        [Display (Name = "Name")]
        [Required]
        public string StudentName { get; set; }
        [Required]
        public Nullable<int> Age { get; set; }
        [Required]
        public string Password { get; set; }
    }
}
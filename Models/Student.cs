using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace RazorTemplatesLawler.Models
{
    public class Student
    {
        [Required]
        public int StudentId { get; set; }
        [Required(ErrorMessage = "Enter a first name.")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Enter a last name.")]
        public string LastName { get; set; }

        [MaxLength(2, ErrorMessage = "Enter a letter grade (ex: A+, B-, C)")]
        [Required(ErrorMessage = "Enter a letter grade.")]
        public string Grade { get; set; }

    }
}

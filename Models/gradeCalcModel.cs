using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Mission4TreyJackson.Models
{
    public class gradeCalcModel
    {
        // setting and getting the values for each variable in the gradeCalc Views page

        // these attributes above each variable validates that there is data entered 
        // and that the data entered is between 0 and 100

        [Required]
        [Range(0,100, ErrorMessage ="Please enter a number between 0 and 100 for the 'Assignment' section")]
        public int Assignment { get; set; }

        [Required]
        [Range(0, 100, ErrorMessage = "Please enter a number between 0 and 100 for the 'Group Projects' section")]
        public int Group { get; set; }

        [Required]
        [Range(0, 100, ErrorMessage = "Please enter a number between 0 and 100 for the 'Quizzes' section")]
        public int Quizzes { get; set; }

        [Required]
        [Range(0, 100, ErrorMessage = "Please enter a number between 0 and 100 for the 'Midterm Exam' section")]
        public int Midterm { get; set; }

        [Required]
        [Range(0, 100, ErrorMessage = "Please enter a number between 0 and 100 for the 'Final Exam' section")]
        public int Final { get; set; }

        [Required]
        [Range(0, 100, ErrorMessage = "Please enter a number between 0 and 100 for the 'INTEX' section")]
        public int Intex { get; set; }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Mission4TreyJackson.Models
{
    public class movieEntry
    {
        // setting and getting the values for each variable in the gradeCalc Views page

        // these attributes above each variable validates that there is data entered 
        // and that the data entered is between 0 and 100

        [Key]
        [Required]
        public int MovieID { get; set; }
        [Required]
        public string Category { get; set; }

        public string Title { get; set; }

        [Required]
        public int Year { get; set; }

        [Required]
        public string Director { get; set; }

        [Required]
        public string Rating { get; set; }

        public string Edited { get; set; }

        public string LentTo { get; set; }

        [MaxLength(25)]
        public string Notes { get; set; }

    }


}

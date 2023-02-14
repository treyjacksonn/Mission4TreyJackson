using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Mission4TreyJackson.Models
{
    public class movieEntry
    {

        [Key]
        [Required]
        // primary key
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


        //Edited, LentTo, and Notes are optionals  

        public string Edited { get; set; }

        public string LentTo { get; set; }

        // Enforces a max limit of 25 per Note field
        [MaxLength(25)]
        public string Notes { get; set; }

    }


}

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
        [Required(ErrorMessage ="Category is required")]
        public int CategoryID { get; set; }
        [Required(ErrorMessage ="Title is required and must be a string")]
        public string Title { get; set; }

        [Required(ErrorMessage ="Year is required and must be an integer")]
        public int Year { get; set; }

        [Required(ErrorMessage = "Director is required and must be a string")]
        public string Director { get; set; }

        [Required(ErrorMessage = "Raing is required")]
        public string Rating { get; set; }


        //Edited, LentTo, and Notes are optionals  
        
        public string Edited { get; set; }

        public string LentTo { get; set; }

        // Enforces a max limit of 25 per Note field
        [MaxLength(25)]
        public string Notes { get; set; }


        //building foreign key relationship
        public Category Category { get; set; }


    }


}

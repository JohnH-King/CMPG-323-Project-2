using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Project_2__26047179.Models
{
    public class Personal
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Age")]
        [Required]
        public int Age { get; set; }

        //add

        public int Attrition { get; set; }

        [Display(Name = "Businesss Travel")]
        public string BusinesssTravel { get; set; }

        [Display(Name = "Daily Rate")]
        public int DailyRate { get; set; }
        public char Gender { get; set; }

        [Display(Name = "Age")]
        public string MaritialStatus { get; set; }

        [Display(Name = "Over 18?")]
        public char Over18 { get; set; }

        [Display(Name = "RelationshipSatisfaction")]
        public int RelationshipSatisfaction { get; set; }


        //-----

        [Required]
        [Display(Name = "Employee")]
        public int EmployeeId { get; set; }

        [ForeignKey("EmployeeId")]
        public virtual Employee Employee { get; set; }
    }
}

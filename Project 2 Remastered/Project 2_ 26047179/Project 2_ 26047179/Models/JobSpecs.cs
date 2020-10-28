using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Project_2__26047179.Models
{
    public class JobSpecs
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Job Role")]
        [Required]
        public string JobRole { get; set; }

        [Required]
        [Display(Name ="Employee")]
        public int EmployeeId { get; set; }

        [ForeignKey("EmployeeId")]
        public virtual Employee Employee { get; set; }
    }
}

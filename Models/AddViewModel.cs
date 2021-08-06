using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace StudentApplicationApp.Models
{
    public class AddViewModel
    {
        [Required(ErrorMessage = "Name is required")]
        public string Name { get; set; }

        [Required(ErrorMessage = "RollNo is required")]
        public int RollNo { get; set; }
        
        [Required(ErrorMessage = "CGPA is required")]
        public double Cgpa { get; set; }
    }
}
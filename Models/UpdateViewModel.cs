using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace StudentApplicationApp.Models
{
    public class UpdateViewModel
    {
        [Required(ErrorMessage = "Name is required")]
        public string Name { get; set; }
        
        [Required(ErrorMessage = "Roll No is required")]
        public int RollNo { get; set; }
        
        [Required(ErrorMessage = "Cgpa is required")]
        public double Cgpa { get; set; }
        
        public string Id { get; set; }
    }
}
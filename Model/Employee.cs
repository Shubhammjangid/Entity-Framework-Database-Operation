using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Model
{
    public class Employee
    {
        
        public int ID { get; set; }

        [Required(ErrorMessage = "Name is required for registration")]
        [Display(Name = "Name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Department name is required")]
        [Display(Name = "Department")]
        public string Department { get; set; }
    }
}

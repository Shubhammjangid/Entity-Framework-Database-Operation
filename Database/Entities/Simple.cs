using System;
using System.Collections.Generic;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace Database.Entities
{
    public partial class Simple
    {
      
        public int Id { get; set; }

        [Display(Name = "Name")]
        [Required(ErrorMessage = "Name is required for registration")]
        public string Name { get; set; }

        [Display(Name = "Department")]
        [Required(ErrorMessage = "Department name is required")]
        public string Department { get; set; }


        public int? DepId { get; set; }
    }
}

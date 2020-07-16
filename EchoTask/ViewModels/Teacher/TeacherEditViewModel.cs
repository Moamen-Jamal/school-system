﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModels
{
    public class TeacherEditViewModel
    {
        public int ID { get; set; }
        [Required(ErrorMessage = "This Field Is Required")]
        public string Name { get; set; }
        [Required(ErrorMessage = "This Field Is Required")]
        [EmailAddress(ErrorMessage = "Enter a Correct Email")]
        public string Email { get; set; }
        [Required(ErrorMessage = "This Field Is Required")]
        [Phone(ErrorMessage = "Enter a Correct Phone Number")]
        public string Phone { get; set; }
    }
}

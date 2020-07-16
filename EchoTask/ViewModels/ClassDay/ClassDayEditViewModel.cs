using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModels
{
    public class ClassDayEditViewModel
    {
        public int ID { get; set; }
        
        [Required(ErrorMessage = "This Field Is Required")]
        public int SchoolID { get; set; }
        [Required(ErrorMessage = "This Field Is Required")]
        public int ClassRoomID { get; set; }
        [Required(ErrorMessage = "This Field Is Required")]
        public int DayID { get; set; }
    }
}

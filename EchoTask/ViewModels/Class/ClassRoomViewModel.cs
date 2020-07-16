using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModels
{
    public class ClassRoomViewModel
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int SchoolID { get; set; }
        public SchoolViewModel School { get; set; }
        public IEnumerable<ClassDayViewModel> ClassDays { get; set; }

    }
}

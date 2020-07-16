using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Entities
{
    public class ClassRoom : BaseModel
    {
        public string Name { get; set; }
        public virtual School School { get; set; }
        public int SchoolID { get; set; }

        
        public virtual ICollection<ClassDay> ClassDays { get; set; }
        public virtual ICollection<Student> Students { get; set; }
    }
}

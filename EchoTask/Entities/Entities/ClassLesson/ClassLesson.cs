using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Entities
{
    public class ClassLesson : BaseModel
    {
        public virtual Teacher Teacher { get; set; }
        public int TeacherID { get; set; }
        public virtual ClassDay ClassDay { get; set; }
        public int ClassDayID { get; set; }
        public virtual Subject Subject { get; set; }
        public int SubjectID { get; set; }

        public virtual Lesson Lesson { get; set; }
        public int LessonID { get; set; }
    }
}

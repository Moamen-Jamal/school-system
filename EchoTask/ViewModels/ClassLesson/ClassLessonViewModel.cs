using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModels
{
    public class ClassLessonViewModel
    {
        public int ID { get; set; }
        public int ClassDayID { get; set; }
        public ClassDayViewModel ClassDay { get; set; }
        public int TeacherID { get; set; }
        public TeacherViewModel Teacher { get; set; }
        public int LessonID { get; set; }
        public LessonViewModel Lesson { get; set; }
        public int SubjectID { get; set; }
        public SubjectViewModel Subject { get; set; }

    }
}

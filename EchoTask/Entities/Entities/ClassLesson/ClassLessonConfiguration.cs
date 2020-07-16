using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Entities
{
    public class ClassLessonConfiguration : EntityTypeConfiguration<ClassLesson>
    {
        public ClassLessonConfiguration()
        {
            ToTable("ClassLesson");

            HasRequired(i => i.Teacher).WithMany(i => i.ClassLessons).
                HasForeignKey(i => i.TeacherID);

            HasRequired(i => i.ClassDay).WithMany(i => i.ClassLessons).
                HasForeignKey(i => i.ClassDayID);

            HasRequired(i => i.Lesson).WithMany(i => i.ClassLessons).
               HasForeignKey(i => i.LessonID);

            HasRequired(i => i.Subject).WithMany(i => i.ClassLessons).
               HasForeignKey(i => i.SubjectID);
        }
    }
}

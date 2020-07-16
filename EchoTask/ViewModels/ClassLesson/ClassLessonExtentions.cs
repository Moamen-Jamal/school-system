using Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModels
{
    public static class ClassLessonLessonExtentions
    {
        public static ClassLessonViewModel ToViewModel(this ClassLesson Model)
        {
            return new ClassLessonViewModel()
            {
                ID = Model.ID,
                ClassDayID = Model.ClassDayID,
                ClassDay = Model.ClassDay.ToViewModel(),
                TeacherID = Model.TeacherID,
                Teacher = Model.Teacher.ToViewModel(),
                LessonID = Model.LessonID,
                Lesson = Model.Lesson.ToViewModel(),
                SubjectID = Model.SubjectID,
                Subject = Model.Subject.ToViewModel(),
            };
        }
        public static ClassLessonEditViewModel ToEditableViewModel(this ClassLesson Model)
        {
            return new ClassLessonEditViewModel()
            {
                ID = Model.ID,

                SubjectID = Model.SubjectID,
                LessonID = Model.LessonID,
                TeacherID = Model.TeacherID,
                ClassDayID = Model.ClassDayID,
            };
        }
        public static ClassLesson ToModel(this ClassLessonEditViewModel EditModel)
        {
            return new ClassLesson()
            {
                ID = EditModel.ID,

                ClassDayID = EditModel.ClassDayID,
                SubjectID = EditModel.SubjectID,
                LessonID = EditModel.LessonID,
                TeacherID = EditModel.TeacherID,
            };
        }
    }
}

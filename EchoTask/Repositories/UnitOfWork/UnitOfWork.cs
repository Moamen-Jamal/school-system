using Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class UnitOfWork
    {
        private EntitiesContext context;
        public Generic<Admin> AdminRepo { get; set; }
        public Generic<ClassDay> ClassDayRepo { get; set; }
        public Generic<ClassLesson> ClassLessonRepo { get; set; }
        public Generic<Student> StudentRepo { get; set; }
        public Generic<School> SchoolRepo { get; set; }
        public Generic<ClassRoom> ClassRoomRepo { get; set; }
        public Generic<Lesson> LessonRepo { get; set; }
        public Generic<Day> DayRepo { get; set; }
        public Generic<Subject> SubjectRepo { get; set; }
        public Generic<Teacher> TeacherRepo { get; set; }

        /////////////////
        public UnitOfWork(
         EntitiesContext _context,
         Generic<Teacher> teacherRepo,
         Generic<Subject> subjectRepo,
         Generic<Day> dayRepo,
         Generic<Lesson> lessonRepo,
         Generic<ClassRoom> classRoomRepo,
         Generic<ClassDay> classDayRepo,
         Generic<School> schoolRepo,
         Generic<Student> studentRepo,       
         Generic<Admin> adminRepo,
         Generic<ClassLesson> classLessonRepo

         )
        {
            context = _context;

            TeacherRepo = teacherRepo;
            TeacherRepo.Context = context;

            SubjectRepo = subjectRepo;
            SubjectRepo.Context = context;

            DayRepo = dayRepo;
            DayRepo.Context = context;

            LessonRepo = lessonRepo;
            LessonRepo.Context = context;

            ClassRoomRepo = classRoomRepo;
            ClassRoomRepo.Context = context;

            ClassDayRepo = classDayRepo;
            ClassDayRepo.Context = context;

            SchoolRepo = schoolRepo;
            SchoolRepo.Context = context;

            StudentRepo = studentRepo;
            StudentRepo.Context = context;

            AdminRepo = adminRepo;
            AdminRepo.Context = context;

            ClassLessonRepo = classLessonRepo;
            ClassLessonRepo.Context = context;
        }

        public int commit()
        {
            return context.SaveChanges();
        }
    }
}

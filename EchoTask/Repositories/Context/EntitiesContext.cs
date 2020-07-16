using Entities.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class EntitiesContext : DbContext
    {
        public EntitiesContext() : base("name=School")
        { }
        public virtual DbSet<ClassRoom> ClassRooms { get; set; }
        public virtual DbSet<ClassDay> ClassDays { get; set; }
        public virtual DbSet<ClassLesson> ClassLessons { get; set; }
        public virtual DbSet<Day> Days { get; set; }
        public virtual DbSet<Admin> Admins { get; set; }
        public virtual DbSet<School> Schools { get; set; }
        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<Teacher> Teachers { get; set; }
        public virtual DbSet<Subject> Subjects { get; set; }
        public virtual DbSet<Lesson> Lessons { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

            modelBuilder.Configurations.Add(new AdminConfiguration());
            modelBuilder.Configurations.Add(new SchoolConfiguration());
            modelBuilder.Configurations.Add(new StudentConfiguration());
            modelBuilder.Configurations.Add(new TeacherConfiguration());
            modelBuilder.Configurations.Add(new SubjectConfiguration());
            modelBuilder.Configurations.Add(new LessonConfiguration());
            modelBuilder.Configurations.Add(new DayConfiguration());
            modelBuilder.Configurations.Add(new ClassRoomConfiguration());
            modelBuilder.Configurations.Add(new ClassDayConfiguration());
            modelBuilder.Configurations.Add(new ClassLessonConfiguration());
        }




    }
}

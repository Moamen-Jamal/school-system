using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Entities
{
    public class TeacherConfiguration : EntityTypeConfiguration<Teacher>
    {
        public TeacherConfiguration()
        {
            ToTable("Teacher");
            Property(i => i.Name).HasMaxLength(50).IsRequired();
            Property(i => i.Phone).HasMaxLength(50).IsRequired();
            Property(i => i.Email).HasMaxLength(50).IsRequired();
            HasMany(i => i.ClassLessons).WithRequired(i => i.Teacher);


        }
    }
}

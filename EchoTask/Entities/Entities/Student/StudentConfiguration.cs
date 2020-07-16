using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Entities
{
    public class StudentConfiguration : EntityTypeConfiguration<Student>
    {
        public StudentConfiguration()
        {
            ToTable("Student");
            Property(i => i.Name).HasMaxLength(50).IsRequired();
            Property(i => i.Phone).HasMaxLength(50).IsRequired();
            Property(i => i.Email).HasMaxLength(50).IsRequired();
            HasRequired(i => i.ClassRoom).WithMany(i => i.Students).
                   HasForeignKey(i => i.ClassID);

        }
    }
}

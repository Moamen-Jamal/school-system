using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Entities
{
    public class ClassDayConfiguration : EntityTypeConfiguration<ClassDay>
    {
        public ClassDayConfiguration()
        {
            ToTable("ClassDay");

            HasRequired(i => i.ClassRoom).WithMany(i => i.ClassDays).
                HasForeignKey(i => i.ClassRoomID);
            HasRequired(i => i.Day).WithMany(i => i.ClassDays).
                HasForeignKey(i => i.DayID);

            HasMany(i => i.ClassLessons).WithRequired(i => i.ClassDay);
        }
    }
}

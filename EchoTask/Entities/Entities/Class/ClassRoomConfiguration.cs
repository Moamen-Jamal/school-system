using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Entities
{
    public class ClassRoomConfiguration : EntityTypeConfiguration<ClassRoom>
    {
        public ClassRoomConfiguration()
        {
            ToTable("Class");
            Property(i => i.Name).HasMaxLength(50).IsRequired();
            HasRequired(i => i.School).WithMany(i => i.ClassRooms).
                HasForeignKey(i => i.SchoolID);
            
            HasMany(i => i.Students).WithRequired(i => i.ClassRoom).WillCascadeOnDelete(false);
            HasMany(i => i.ClassDays).WithRequired(i => i.ClassRoom).WillCascadeOnDelete(false); ;
            

        }
    }
}

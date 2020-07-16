using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Entities
{
    public class SchoolConfiguration : EntityTypeConfiguration<School>
    {
        public SchoolConfiguration()
        {
            ToTable("School");
            Property(i => i.Name).HasMaxLength(50).IsRequired();
            HasMany(i => i.ClassRooms).WithRequired(i => i.School);
        }
    }
}

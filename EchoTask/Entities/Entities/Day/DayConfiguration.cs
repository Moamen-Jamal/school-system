using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Entities
{
    public class DayConfiguration : EntityTypeConfiguration<Day>
    {
        public DayConfiguration()
        {
            ToTable("Day");
            Property(i => i.Name).HasMaxLength(50).IsRequired();
       
            HasMany(i => i.ClassDays).WithRequired(i => i.Day);
            
        }
    }
}

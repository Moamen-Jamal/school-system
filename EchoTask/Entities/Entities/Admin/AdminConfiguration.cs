using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Entities
{
    public class AdminConfiguration : EntityTypeConfiguration<Admin>
    {
        public AdminConfiguration()
        {
            ToTable("Admin");
            Property(i => i.UserName).IsRequired();
            Property(i => i.Password).IsRequired();
        }
    }
}

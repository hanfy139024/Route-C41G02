using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Route.C41.G02.DAL.Data.Configurations;
using Route.C41.G02.DAL.Modles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Route.C41.G02.DAL.Data.Configurations
{
     class Departmentconfigurations : IEntityTypeConfiguration<Department>
    {
        

        public void Configure(EntityTypeBuilder<Department> builder)
        {
            builder.Property(D=> D.Id).UseIdentityColumn(10, 10);
            builder.Property(D=> D.Code).HasColumnName("varchar").HasMaxLength(50).IsRequired();
            builder.Property(D =>D.Name).HasColumnName("varchar").HasMaxLength(50).IsRequired();

        }
    }
}

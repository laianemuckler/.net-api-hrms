using HRMS.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMS.Infrastructure.EntitiesConfiguration
{
    public class ContractConfiguration : IEntityTypeConfiguration<Contract>
    {
        public void Configure(EntityTypeBuilder<Contract> builder)
        {
            builder.HasKey(t => t.Id);
            builder.Property(x =>x.Id).UseIdentityColumn();
            builder.Property(p => p.Description).HasMaxLength(100).IsRequired();
           
        }


    }
}

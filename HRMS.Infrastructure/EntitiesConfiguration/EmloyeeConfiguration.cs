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
    public class EmloyeeConfiguration : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder.HasKey(t => t.Id);
            builder.Property(p => p.Name).HasMaxLength(200).IsRequired();

            builder.Property(p => p.Payment).HasPrecision(10, 2);

            builder.HasOne(e => e.Contract).WithMany(e => e.Employees)
                .HasForeignKey(e => e.ContractId);
        }
    }
}

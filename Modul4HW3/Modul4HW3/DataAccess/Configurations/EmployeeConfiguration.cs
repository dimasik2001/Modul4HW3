using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Modul4HW3.Services;

namespace Modul4HW3.Entities.Configurations
{
    public class EmployeeConfiguration : IEntityTypeConfiguration<Employee>
    {
        private EntityInsertService _entityInsertService = new EntityInsertService();
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder.Property(t => t.FirstName).IsRequired().HasMaxLength(50);
            builder.Property(t => t.LastName).IsRequired().HasMaxLength(50);
            builder.Property(t => t.HiredDate).IsRequired().HasMaxLength(7);
            builder.Property(t => t.OfficeId).IsRequired();
            builder.Property(t => t.TitleId).IsRequired();
            builder.HasData(_entityInsertService.GetEmployees());
        }
    }
}

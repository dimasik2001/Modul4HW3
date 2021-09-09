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
    public class EmployeeProjectConfiguration : IEntityTypeConfiguration<EmployeeProject>
    {
        private EntityInsertService _entityInsertService = new EntityInsertService();
        public void Configure(EntityTypeBuilder<EmployeeProject> builder)
        {
            builder.Property(t => t.EmployeeId).IsRequired();
            builder.Property(t => t.Rate).IsRequired();
            builder.Property(t => t.StartedDate).IsRequired().HasMaxLength(7);
            builder.Property(t => t.ProjectId).IsRequired();
            builder.HasData(_entityInsertService.GetEmployeeProject());
        }
    }
}

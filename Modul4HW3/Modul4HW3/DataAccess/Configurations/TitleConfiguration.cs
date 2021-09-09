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
    public class TitleConfiguration : IEntityTypeConfiguration<Title>
    {
        private EntityInsertService _entityInsertService = new EntityInsertService();
        public void Configure(EntityTypeBuilder<Title> builder)
        {
            builder.Property(t => t.Name).IsRequired().HasMaxLength(50);
            builder.HasData(_entityInsertService.GetTitles());
        }
    }
}

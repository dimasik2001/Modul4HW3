﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Modul4HW3.Services;

namespace Modul4HW3.Entities.Configurations
{
    public class OfficeConfiguration : IEntityTypeConfiguration<Office>
    {
        private EntityInsertService _entityInsertService = new EntityInsertService();
        public void Configure(EntityTypeBuilder<Office> builder)
        {
            builder.Property(t => t.Location).IsRequired().HasMaxLength(100);
            builder.Property(t => t.Title).IsRequired().HasMaxLength(100);
            builder.HasData(_entityInsertService.GetOffices());
        }
    }
}

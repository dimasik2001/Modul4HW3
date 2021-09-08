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
    public class ClientConfiguration : IEntityTypeConfiguration<Client>
    {
        private EntityInsertService _entityInsertService = new EntityInsertService();
        public void Configure(EntityTypeBuilder<Client> builder)
        {
            builder.Property(t => t.FirstName).IsRequired();
            builder.Property(t => t.LastName).IsRequired();
            builder.Property(t => t.DateOfBirth).HasMaxLength(7);
            builder.Property(t => t.Revenue).IsRequired();
            builder.HasData(_entityInsertService.GetClients());
        }
    }
}

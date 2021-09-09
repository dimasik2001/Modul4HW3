using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Modul4HW3.Services;

namespace Modul4HW3.Entities.Configurations
{
    public class ProjectConfiguration : IEntityTypeConfiguration<Project>
    {
        private EntityInsertService _entityInsertService = new EntityInsertService();
        public void Configure(EntityTypeBuilder<Project> builder)
        {
            builder.Property(t => t.Name).IsRequired().HasMaxLength(50);
            builder.Property(t => t.Budget).IsRequired();
            builder.Property(t => t.StartedDate).IsRequired().HasMaxLength(7);
            builder.Property(t => t.ClientId).IsRequired();
            builder.HasOne(t => t.Client).WithMany(h => h.Projects).HasForeignKey(p => p.ClientId);
            builder.HasData(_entityInsertService.GetProjects());
        }
    }
}

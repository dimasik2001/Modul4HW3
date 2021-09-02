using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Modul4HW3.Entities.Configurations
{
    public class ProjectConfiguration : IEntityTypeConfiguration<Project>
    {
        public void Configure(EntityTypeBuilder<Project> builder)
        {
            builder.Property(t => t.Name).IsRequired().HasMaxLength(50);
            builder.Property(t => t.Budget).IsRequired();
            builder.Property(t => t.StartedDate).IsRequired().HasMaxLength(7);
        }
    }
}

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Task3
{
    public class TopicConfigurations : IEntityTypeConfiguration<Topic>
    {
        public void Configure(EntityTypeBuilder<Topic> builder)
        {
            builder.ToTable("Topics");
            builder.Property(t => t.ID).UseIdentityColumn(1, 1);
            builder.Property(t => t.Name).HasMaxLength(50).IsRequired();
        }
    }
}

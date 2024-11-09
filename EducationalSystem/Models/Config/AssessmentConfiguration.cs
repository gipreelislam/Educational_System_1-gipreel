using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EducationalSystem.Models.Config
{
    public class AssessmentConfiguration : IEntityTypeConfiguration<Assessments>
    {
        public void Configure(EntityTypeBuilder<Assessments> builder)
        {
            builder.Property(x => x.AssessmentType).HasMaxLength(100);
            builder.Property(x => x.CreatedDate)
                .HasColumnType("datetime2")
                .HasPrecision(0)
                .IsRequired()
                .HasDefaultValueSql("GETDATE()");
        }
    }
}

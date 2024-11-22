using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EducationalSystem.DAL.Models.Config
{
    public class CategoriesConfiguration : IEntityTypeConfiguration<Categories>
    {
        public void Configure(EntityTypeBuilder<Categories> builder)
        {
            builder.Property(x => x.CategoryName).HasMaxLength(50).IsRequired();
            
        }
    }
}

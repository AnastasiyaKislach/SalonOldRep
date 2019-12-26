using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Salon.Data.Entities;

namespace Salon.Data.Configurations
{
	public class CategoryConfiguration : IEntityTypeConfiguration<CategoryEntity>
	{
		public void Configure(EntityTypeBuilder<CategoryEntity> builder)
		{
			builder
				.HasMany(a => a.Accessories)
				.WithOne(c => c.Category)
				.HasForeignKey(c => c.CategoryId)
				.OnDelete(DeleteBehavior.Cascade);
		}
	}
}

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Salon.Data.Entities;

namespace Salon.Data.Configurations
{
	public class BrandConfiguration : IEntityTypeConfiguration<BrandEntity>
	{
		public void Configure(EntityTypeBuilder<BrandEntity> builder)
		{
			builder
				.HasMany(a => a.Collections)
				.WithOne(c => c.Brand)
				.HasForeignKey(c => c.BrandId)
				.OnDelete(DeleteBehavior.Cascade);
		}
	}
}

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Salon.Data.Entities;

namespace Salon.Data.Configurations
{
	public class CollectionConfiguration : IEntityTypeConfiguration<CollectionEntity>
	{
		public void Configure(EntityTypeBuilder<CollectionEntity> builder)
		{
			builder
				.HasMany(a => a.Dresses)
				.WithOne(c => c.Collection)
				.HasForeignKey(c => c.CollectionId)
				.OnDelete(DeleteBehavior.Cascade);
		}
	}
}

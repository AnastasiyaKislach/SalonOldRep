using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Salon.Data.Entities;

namespace Salon.Data.Configurations
{
	public class DressAppointmentConfiguration : IEntityTypeConfiguration<DressAppointmentEntity>
	{
		public void Configure(EntityTypeBuilder<DressAppointmentEntity> builder)
		{
			builder
				.HasOne(u => u.Appointment)
				.WithMany(d => d.DressAppointments)
				.HasForeignKey(d => d.AppointmentId);

			builder
				.HasOne(u => u.Dress)
				.WithMany(d => d.DressAppointments)
				.HasForeignKey(d => d.DressId);
		}
	}
}

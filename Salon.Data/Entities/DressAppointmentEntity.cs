using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Salon.Data.Entities
{
	[Table("DressAppointment")]
	public class DressAppointmentEntity : IEntityBase
	{
		[Key]
		public int Id { get; set; }

		public int DressId { get; set; }
		public DressEntity Dress { get; set; }

		public int AppointmentId { get; set; }
		public AppointmentEntity Appointment { get; set; }
	}
}

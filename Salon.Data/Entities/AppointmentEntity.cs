using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Salon.Data.Entities
{
	[Table("Appointment")]
	public class AppointmentEntity : IEntityBase
	{
		[Key]
		public int Id { get; set; }

		[Required]
		[MaxLength(1024)]
		public string Name { get; set; }

		[Required]
		[MaxLength(1024)]
		public string Phone { get; set; }

		[Required]
		public DateTime Date { get; set; }

		[MaxLength(2048)]
		public string Details { get; set; }

		public bool IsApprove { get; set; }

		public DateTime ApprovedDate { get; set; }

		public IList<DressAppointmentEntity> DressAppointments { get; set; }
	}
}
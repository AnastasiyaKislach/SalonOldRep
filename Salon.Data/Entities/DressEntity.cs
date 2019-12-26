using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Salon.Data.Entities
{
	[Table("Dress")]
	public class DressEntity : IEntityBase
	{
		[Key]
		public int Id { get; set; }

		[Required]
		[MaxLength(1024)]
		public string ImageUrl1 { get; set; }

		[MaxLength(1024)]
		public string ImageUrl2 { get; set; }

		[MaxLength(1024)]
		public string ImageUrl3 { get; set; }

		[Required]
		[MaxLength(1024)]
		public string Title { get; set; }

		[MaxLength(2048)]
		public string Description { get; set; }

		public int CollectionId { get; set; }
		public CollectionEntity Collection { get; set; }

		public IList<DressAppointmentEntity> DressAppointments { get; set; }
	}
}
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Salon.Data.Entities
{
	[Table("Accessory")]
	public class AccessoryEntity : IEntityBase
	{
		[Key]
		public int Id { get; set; }

		[Required]
		[MaxLength(1024)]
		public string Title { get; set; }

		[Required]
		[MaxLength(1024)]
		public string ImageUrl { get; set; }

		[MaxLength(2048)]
		public string Description { get; set; }

		public int CategoryId { get; set; }

		public CategoryEntity Category { get; set; }
	}
}

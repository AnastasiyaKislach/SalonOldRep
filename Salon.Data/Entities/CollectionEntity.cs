using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Salon.Data.Entities
{
	[Table("Collection")]
	public class CollectionEntity : IDeletableEntity
	{
		[Key]
		public int Id { get; set; }

		[Required]
		[MaxLength(1024)]
		public string ImageUrl { get; set; }

		[Required]
		[MaxLength(1024)]
		public string Title { get; set; }

		public int BrandId { get; set; }
		public BrandEntity Brand { get; set; }

		public IList<DressEntity> Dresses { get; set; }

		public bool isActive { get; set; }

		public bool IsDeleted { get; set; } = false;
	}
}
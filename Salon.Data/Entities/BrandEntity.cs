using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Salon.Data.Entities
{
	[Table("Brand")]
	public class BrandEntity : IDeletableEntity
	{
		[Key]
		public int Id { get; set; }

		[Required]
		[MaxLength(1024)]
		public string Title { get; set; }

		[MaxLength(1024)]
		public string ImageUrl { get; set; }

		public bool IsTitleVisible { get; set; }

		public bool IsDeleted { get; set; } = false;

		public IList<CollectionEntity> Collections { get; set; }
	}
}

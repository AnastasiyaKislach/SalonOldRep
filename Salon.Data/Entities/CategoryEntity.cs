using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Salon.Data.Entities
{
	[Table("Category")]
	public class CategoryEntity : IDeletableEntity
	{
		[Key]
		public int Id { get; set; }

		[Required]
		[MaxLength(1024)]
		public string Title { get; set; }

		[Required]
		[MaxLength(1024)]
		public string TitleRus { get; set; }

		public bool IsDeleted { get; set; } = false;

		public IList<AccessoryEntity> Accessories { get; set; }
	}
}
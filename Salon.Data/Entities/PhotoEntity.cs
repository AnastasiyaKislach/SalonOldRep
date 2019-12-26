using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Salon.Data.Entities
{
	[Table("Photo")]
	public class PhotoEntity : IEntityBase
	{
		[Key]
		public int Id { get; set; }

		[Required]
		[MaxLength(1024)]
		public string Author { get; set; }

		[Required]
		[MaxLength(1024)]
		public string ImageUrl { get; set; }
	}
}

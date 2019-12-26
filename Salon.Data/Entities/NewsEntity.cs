using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Salon.Data.Entities
{
	[Table("News")]
	public class NewsEntity : IEntityBase
	{
		[Key]
		public int Id { get; set; }

		[Required]
		[MaxLength(1024)]
		public string Title { get; set; }

		[Required]
		[MaxLength(1024)]
		public string ImageUrl { get; set; }

		[Required]
		[MaxLength(2048)]
		public string PreviewContent { get; set; }

		[MaxLength(2048)]
		public string Content { get; set; }

		public DateTime Date { get; set; }
	}
}

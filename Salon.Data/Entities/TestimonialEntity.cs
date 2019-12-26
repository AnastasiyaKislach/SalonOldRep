using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Salon.Data.Entities
{
	[Table("Testimonial")]
	public class TestimonialEntity : IDeletableEntity
	{
		[Key]
		public int Id { get; set; }

		[Required]
		[MaxLength(1024)]
		public string Author { get; set; }

		[Required]
		[MaxLength(1024)]
		public string Email { get; set; }

		[Required]
		[MaxLength(1024)]
		public string ImageUrl { get; set; }

		[Required]
		[MaxLength(4096)]
		public string Text { get; set; }

		public DateTime CreationTime { get; set; }

		public bool IsApproved { get; set; }

		public bool IsDeleted { get; set; } = false;
	}
}

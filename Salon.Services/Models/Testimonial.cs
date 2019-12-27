using System;

namespace Salon.Services.Models
{
	public class Testimonial : IModel
	{
		public int Id { get; set; }

		public string Author { get; set; }

		public string Email { get; set; }

		public string ImageUrl { get; set; }

		public string Text { get; set; }

		public DateTime CreationTime { get; set; }

		public bool IsApproved { get; set; }

		public bool IsDeleted { get; set; } = false;
	}
}

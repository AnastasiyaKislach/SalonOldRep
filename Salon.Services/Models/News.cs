using System;

namespace Salon.Services.Models
{
	public class News : IModel
	{
		public int Id { get; set; }

		public string Title { get; set; }

		public string ImageUrl { get; set; }

		public string PreviewContent { get; set; }

		public string Content { get; set; }

		public DateTime Date { get; set; }
	}
}

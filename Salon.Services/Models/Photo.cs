namespace Salon.Services.Models
{
	public class Photo : IModel
	{
		public int Id { get; set; }

		public string Author { get; set; }

		public string ImageUrl { get; set; }
	}
}

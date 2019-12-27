namespace Salon.Services.Models
{
	public class Accessory : IModel
	{
		public int Id { get; set; }

		public string Title { get; set; }

		public string ImageUrl { get; set; }

		public string Description { get; set; }

		public int CategoryId { get; set; }
	}
}

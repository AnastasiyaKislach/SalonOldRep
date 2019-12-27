namespace Salon.Services.Models
{
	public class Dress : IModel
	{
		public int Id { get; set; }

		public string ImageUrl1 { get; set; }

		public string ImageUrl2 { get; set; }

		public string ImageUrl3 { get; set; }

		public string Title { get; set; }

		public string Description { get; set; }

		public int CollectionId { get; set; }
	}
}
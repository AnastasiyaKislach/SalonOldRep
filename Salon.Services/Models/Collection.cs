namespace Salon.Services.Models
{
	public class Collection : IModel
	{
		public int Id { get; set; }

		public string ImageUrl { get; set; }

		public string Title { get; set; }

		public int BrandId { get; set; }

		public int[] Dresses { get; set; }

		public bool isActive { get; set; }

		public bool IsDeleted { get; set; } = false;
	}
}

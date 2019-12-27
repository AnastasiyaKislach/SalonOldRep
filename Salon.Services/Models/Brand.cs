namespace Salon.Services.Models
{
	public class Brand: IModel
	{
		public int Id { get; set; }

		public string Title { get; set; }

		public string ImageUrl { get; set; }

		public bool IsTitleVisible { get; set; }

		public bool IsDeleted { get; set; } = false;

		public int[] Collections { get; set; }
	}
}

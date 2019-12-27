namespace Salon.Services.Models
{
	public class Category : IModel
	{
		public int Id { get; set; }

		public string Title { get; set; }

		public string TitleRus { get; set; }

		public bool IsDeleted { get; set; } = false;

		public int[] Accessories { get; set; }
	}
}

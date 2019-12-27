namespace Salon.Services.Models
{
	public class Settings : IModel
	{
		public int Id { get; set; }
		public string Key { get; set; }
		public string Value { get; set; }
	}
}

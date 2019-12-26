using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Salon.Data.Entities
{
	[Table("Settings")]
	public class SettingsEntity : IEntityBase
	{
		[Key]
		public int Id { get; set; }
		public string Key { get; set; }
		public string Value { get; set; }
	}
}

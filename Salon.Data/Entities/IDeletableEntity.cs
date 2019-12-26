namespace Salon.Data.Entities
{
	public interface IDeletableEntity : IEntityBase
	{
		bool IsDeleted { get; set; }
	}
}

using System.Threading.Tasks;
using Salon.Services.Models;

namespace Salon.Services.Contracts
{
	public interface ICollectionService : IGenericService<Collection>
	{
		Task<bool> MarkDeleted(int id);
	}
}

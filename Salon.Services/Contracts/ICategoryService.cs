using System.Threading.Tasks;
using Salon.Services.Models;

namespace Salon.Services.Contracts
{
	public interface ICategoryService : IGenericService<Category>
	{
		Task<bool> MarkDeleted(int id);
	}
}
